//
// System.IO.Stream.cs
//
// Authors:
//   Dietmar Maurer (dietmar@ximian.com)
//   Miguel de Icaza (miguel@ximian.com)
//   Gonzalo Paniagua Javier (gonzalo@ximian.com)
//   Marek Safar (marek.safar@gmail.com)
//
// (C) 2001, 2002 Ximian, Inc.  http://www.ximian.com
// (c) 2004 Novell, Inc. (http://www.novell.com)
// Copyright 2011 Xamarin, Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using System.Runtime.InteropServices;
using System.Threading;
using SharpKit.JavaScript;

namespace System.IO
{
    [JsType(JsMode.Clr, Filename = "~/res/System.IO/Stream.js")]
	public abstract class Stream : IDisposable
	{
		public static readonly Stream Null = new NullStream ();

		Func<byte[], int, int, int> async_read;
		Action<byte[], int, int> async_write;
		AutoResetEvent async_event;

		protected Stream ()
		{
		}

		public abstract bool CanRead
		{
			get;
		}

		public abstract bool CanSeek
		{
			get;
		}

		public abstract bool CanWrite
		{
			get;
		}

		public virtual bool CanTimeout {
			get {
				return false;
			}
		}

		public abstract long Length
		{
			get;
		}

		public abstract long Position
		{
			get;
			set;
		}


		public void Dispose ()
		{
			Close ();
		}

		protected virtual void Dispose (bool disposing)
		{
			if (async_event != null && disposing) {
				async_event.Close ();
				async_event = null;
			}
		}

		public virtual void Close ()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}

		public virtual int ReadTimeout {
			get {
				throw new InvalidOperationException ("Timeouts are not supported on this stream.");
			}
			set {
				throw new InvalidOperationException ("Timeouts are not supported on this stream.");
			}
		}

		public virtual int WriteTimeout {
			get {
				throw new InvalidOperationException ("Timeouts are not supported on this stream.");
			}
			set {
				throw new InvalidOperationException ("Timeouts are not supported on this stream.");
			}
		}

		public static Stream Synchronized (Stream stream)
		{
			return new SynchronizedStream (stream);
		}

		[Obsolete ("CreateWaitHandle is due for removal.  Use \"new ManualResetEvent(false)\" instead.")]
		protected virtual WaitHandle CreateWaitHandle()
		{
			return new ManualResetEvent (false);
		}
		
		public abstract void Flush ();

		public abstract int Read ([In,Out] byte[] buffer, int offset, int count);

		public virtual int ReadByte ()
		{
			byte[] buffer = new byte [1];

			if (Read (buffer, 0, 1) == 1)
				return buffer [0];
			
			return -1;
		}
#if !JAVASCRIPT
		public abstract long Seek (long offset, SeekOrigin origin);
#endif
		public abstract void SetLength (long value);

		public abstract void Write (byte[] buffer, int offset, int count);

		public virtual void WriteByte (byte value)
		{
			byte[] buffer = new byte [1];

			buffer [0] = value;

			Write (buffer, 0, 1);
		}

		public virtual IAsyncResult BeginRead (byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!CanRead)
				throw new NotSupportedException ("This stream does not support reading");

            if (async_event == null)
            {
                System.Threading.Monitor.Enter(this);
                try
                {
                    if (async_event == null)
                        async_event = new AutoResetEvent(true);
                }
                finally
                {
                    System.Threading.Monitor.Exit(this);
                }
            }

		    async_event.WaitOne ();
			async_read = Read;
			return async_read.BeginInvoke (buffer, offset, count, callback, state);
		}

		public virtual IAsyncResult BeginWrite (byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!CanWrite)
				throw new NotSupportedException ("This stream does not support writing");

			if (async_event == null) {
                System.Threading.Monitor.Enter(this);
                try
                {
                    if (async_event == null)
                        async_event = new AutoResetEvent(true);
                }
                finally
                {
                    System.Threading.Monitor.Exit(this);
                }
			}

			async_event.WaitOne ();
			async_write = Write;
			return async_write.BeginInvoke (buffer, offset, count, callback, state);
		}
		
		public virtual int EndRead (IAsyncResult asyncResult)
		{
			if (asyncResult == null)
				throw new ArgumentNullException ("asyncResult");

			if (async_read == null)
				throw new ArgumentException ("EndRead cannot be called multiple times");

			try {
				return async_read.EndInvoke (asyncResult);
			} finally {
				async_read = null;
				async_event.Set ();
			}
		}

		public virtual void EndWrite (IAsyncResult asyncResult)
		{
			if (asyncResult == null)
				throw new ArgumentNullException ("asyncResult");

			if (async_write == null)
				throw new ArgumentException ("EndWrite cannot be called multiple times");

			try {
				async_write.EndInvoke (asyncResult);
			} finally {
				async_write = null;
				async_event.Set ();
			}
		}

#if MOONLIGHT || NET_4_0 || MOBILE
		public void CopyTo (Stream destination)
		{
			CopyTo (destination, 16*1024);
		}

		public void CopyTo (Stream destination, int bufferSize)
		{
			if (destination == null)
				throw new ArgumentNullException ("destination");
			if (!CanRead)
				throw new NotSupportedException ("This stream does not support reading");
			if (!destination.CanWrite)
				throw new NotSupportedException ("This destination stream does not support writing");
			if (bufferSize <= 0)
				throw new ArgumentOutOfRangeException ("bufferSize");

			var buffer = new byte [bufferSize];
			int nread;
			while ((nread = Read (buffer, 0, bufferSize)) != 0)
				destination.Write (buffer, 0, nread);
		}

#if NET_4_5
		[ObsoleteAttribute("Do not call or override this method")]
#endif
		protected virtual void ObjectInvariant ()
		{
		}
#endif
		
#if NET_4_5

		public Task CopyToAsync (Stream destination)
		{
			return CopyToAsync (destination, 16 * 1024, CancellationToken.None);
		}

		public Task CopyToAsync (Stream destination, int bufferSize)
		{
			return CopyToAsync (destination, bufferSize, CancellationToken.None);
		}

		public virtual Task CopyToAsync (Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			if (destination == null)
				throw new ArgumentNullException ("destination");
			if (!CanRead)
				throw new NotSupportedException ("This stream does not support reading");
			if (!destination.CanWrite)
				throw new NotSupportedException ("This destination stream does not support writing");
			if (bufferSize <= 0)
				throw new ArgumentOutOfRangeException ("bufferSize");

			if (cancellationToken.IsCancellationRequested)
				return TaskConstants.Canceled;

			return CopyToAsync (destination, new byte[bufferSize], cancellationToken);
		}

		async Task CopyToAsync (Stream destination, byte[] buffer, CancellationToken cancellationToken)
		{
			int nread;
			while ((nread = await ReadAsync (buffer, 0, buffer.Length).ConfigureAwait (false)) != 0)
				await destination.WriteAsync (buffer, 0, nread, cancellationToken).ConfigureAwait (false);
		}

		public Task FlushAsync ()
		{
			return FlushAsync (CancellationToken.None);
		}

		public virtual Task FlushAsync (CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
				return TaskConstants.Canceled;

			return Task.Factory.StartNew (l => ((Stream) l).Flush (), this, cancellationToken);
		}

		public Task<int> ReadAsync (byte[] buffer, int offset, int count)
		{
			return ReadAsync (buffer, offset, count, CancellationToken.None);
		}

		public virtual Task<int> ReadAsync (byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
				return TaskConstants<int>.Canceled;

			return Task<int>.Factory.FromAsync (BeginRead, EndRead, buffer, offset, count, null);
		}

		public Task WriteAsync (byte[] buffer, int offset, int count)
		{
			return WriteAsync (buffer, offset, count, CancellationToken.None);
		}

		public virtual Task WriteAsync (byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return Task.Factory.FromAsync (BeginWrite, EndWrite, buffer, offset, count, null);
		}
#endif
	}
    [JsType(JsMode.Clr, Filename = "~/res/System.IO/Stream.js")]
	class NullStream : Stream
	{
		public override bool CanRead
		{
			get {
				return true;
			}
		}

		public override bool CanSeek
		{
                        get {
                                return true;
                        }
                }

                public override bool CanWrite
		{
                        get {
                                return true;
                        }
                }

		public override long Length
		{
			get {
				return 0;
			}
		}

		public override long Position
		{
			get {
				return 0;
			}
			set {
			}
		}

		public override void Flush ()
		{
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int ReadByte ()
		{
			return -1;
		}
#if !JAVASCRIPT
		public override long Seek (long offset, SeekOrigin origin)
		{
			return 0;
		}
#endif
		public override void SetLength (long value)
		{
		}

		public override void Write (byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte (byte value)
		{
		}
	}
    [JsType(JsMode.Clr, Filename = "~/res/System.IO/Stream.js")]
	class SynchronizedStream : Stream {
		Stream source;
		object slock;
			
		internal SynchronizedStream (Stream source)
		{
			this.source = source;
			slock = new object ();
		}

        public override bool CanRead
        {
            get
            {
                System.Threading.Monitor.Enter(slock);
                try
                {
                    return source.CanRead;
                }
                finally
                {
                    System.Threading.Monitor.Exit(slock);
                }

            }
        }

        public override bool CanSeek
		{
            get
            {
                System.Threading.Monitor.Enter(slock);
                try
                {
                    return source.CanSeek;
                }
                finally
                {
                    System.Threading.Monitor.Exit(slock);
                }
            }
		}

                public override bool CanWrite
		{
                        get {
                            System.Threading.Monitor.Enter(slock);
                            try
                            {
                                return source.CanWrite;
                            }
                            finally
                            {
                                System.Threading.Monitor.Exit(slock);
                            }

                        }
                }

		public override long Length
		{
			get {
                System.Threading.Monitor.Enter(slock);
                try
                {
                    return source.Length;
                }
                finally
                {
                    System.Threading.Monitor.Exit(slock);
                }
			}
		}

		public override long Position
		{
			get {
                System.Threading.Monitor.Enter(slock);
                try
                {
                    return source.Position;
                }
                finally
                {
                    System.Threading.Monitor.Exit(slock);
                }
			}
			set {
                System.Threading.Monitor.Enter(slock);
                try
                {
                    	source.Position = value;
                }
                finally
                {
                    System.Threading.Monitor.Exit(slock);
                }				
			}
		}

		public override void Flush ()
		{
            System.Threading.Monitor.Enter(slock);
            try
            {
            	source.Flush ();
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }			
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
            System.Threading.Monitor.Enter(slock);
            try
            {
              	return source.Read (buffer, offset, count);
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }	
		}

        public override int ReadByte()
        {
            System.Threading.Monitor.Enter(slock);
            try
            {
                return source.ReadByte();
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }
        }

#if !JAVASCRIPT
		public override long Seek (long offset, SeekOrigin origin)
		{
			lock (slock)
				return source.Seek (offset, origin);
		}
#endif
		public override void SetLength (long value)
		{
            System.Threading.Monitor.Enter(slock);
            try
            {
          			source.SetLength (value);
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }
		}

		public override void Write (byte[] buffer, int offset, int count)
		{
            System.Threading.Monitor.Enter(slock);
            try
            {
                source.Write(buffer, offset, count);
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }

		}

		public override void WriteByte (byte value)
		{
            System.Threading.Monitor.Enter(slock);
            try
            {
            source.WriteByte (value);
            }
            finally
            {
                System.Threading.Monitor.Exit(slock);
            }
		}
	}
}
