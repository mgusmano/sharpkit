using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.fs
{
    class Utils
    {
        /// <summary>
        /// Asynchronous rename(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        /// <returns></returns>
        public object rename(JsString oldPath, JsString newPath) { return null; }
        /// <summary>
        /// Asynchronous rename(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object rename(JsString oldPath, JsString newPath, JsAction<JsError> callback) { return null; }
        /// <summary>
        /// Synchronous rename(2).
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        /// <returns></returns>
        public object renameSync(JsString oldPath, JsString newPath) { return null; }
        /// <summary>
        /// Asynchronous ftruncate(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public object truncate(object fd, JsNumber len) { return null; }
        /// <summary>
        /// Asynchronous ftruncate(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="len"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object truncate(object fd, JsNumber len, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous ftruncate(2).
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public object truncateSync(object fd, JsNumber len) { return null; }
        /// <summary>
        /// Asynchronous chown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object chown(JsString path, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous chown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object chown(JsString path, JsNumber uid, JsNumber gid, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous chown(2).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object chownSync(JsString path, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous fchown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object fchown(object fd, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous fchown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object fchown(object fd, JsNumber uid, JsNumber gid, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous fchown(2). 
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object fchownSync(object fd, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous lchown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object lchown(JsString path, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous lchown(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object lchown(JsString path, JsNumber uid, JsNumber gid, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous lchown(2). 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="uid"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public object lchownSync(JsString path, JsNumber uid, JsNumber gid) { return null; }
        /// <summary>
        /// Asynchronous chmod(2). No arguments other than a possible exception are given to the completion callback. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object chmod(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous chmod(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object chmod(JsString path, JsString mode, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous chmod(2).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object chmodSync(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous fchmod(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object fchmod(object fd, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous fchmod(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object fchmod(object fd, JsString mode, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous fchmod(2).
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object fchmodSync(object fd, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous lchmod(2). No arguments other than a possible exception are given to the completion callback.
        /// Only available on Mac OS X.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object lchmod(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous lchmod(2). No arguments other than a possible exception are given to the completion callback.
        /// Only available on Mac OS X.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object lchmod(JsString path, JsString mode, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous lchmod(2).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object lchmodSync(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous stat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. See the fs.Stats section below for more information.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object stat(JsString path) { return null; }
        /// <summary>
        /// Asynchronous stat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. See the fs.Stats section below for more information.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object stat(JsString path, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronous lstat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. lstat() is identical to stat(), except that if JsString path is a symbolic link, then the link itself is stat-ed, not the file that it refers to. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object lstat(JsString path) { return null; }
        /// <summary>
        /// Asynchronous lstat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. lstat() is identical to stat(), except that if JsString path is a symbolic link, then the link itself is stat-ed, not the file that it refers to.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object lstat(JsString path, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronous fstat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. fstat() is identical to stat(), except that the file to be stat-ed is specified by the file descriptor object fd. 
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public object fstat(object fd) { return null; }
        /// <summary>
        /// Asynchronous fstat(2). The callback gets two arguments (err, stats) where stats is a fs.Stats object. fstat() is identical to stat(), except that the file to be stat-ed is specified by the file descriptor object fd.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object fstat(object fd, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous stat(2). Returns an instance of fs.Stats.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Stats statSync(JsString path) { return null; }
        /// <summary>
        /// Synchronous lstat(2). Returns an instance of fs.Stats.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Stats lstatSync(JsString path) { return null; }
        /// <summary>
        /// Synchronous fstat(2). Returns an instance of fs.Stats.
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public Stats fstatSync(object fd) { return null; }
        /// <summary>
        /// Asynchronous link(2). No arguments other than a possible exception are given to the completion callback. 
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        public object link(JsString srcPath, JsString dstPath) { return null; }
        /// <summary>
        /// Asynchronous link(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object link(JsString srcPath, JsString dstPath, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous link(2). 
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        public object linkSync(JsString srcPath, JsString dstPath) { return null; }
        /// <summary>
        /// Asynchronous symlink(2). No arguments other than a possible exception are given to the completion callback. type argument can be either 'dir', 'file', or 'junction' (default is 'file'). It is only used on Windows (ignored on other platforms). Note that Windows junction points require the destination JsString path to be absolute. When using 'junction', the destination argument will automatically be normalized to absolute JsString path. 
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        public object symlink(JsString srcPath, JsString dstPath) { return null; }
        /// <summary>
        /// Asynchronous symlink(2). No arguments other than a possible exception are given to the completion callback. type argument can be either 'dir', 'file', or 'junction' (default is 'file'). It is only used on Windows (ignored on other platforms). Note that Windows junction points require the destination JsString path to be absolute. When using 'junction', the destination argument will automatically be normalized to absolute JsString path.
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object symlink(JsString srcPath, JsString dstPath, JsString type) { return null; }
        /// <summary>
        /// Asynchronous symlink(2). No arguments other than a possible exception are given to the completion callback. type argument can be either 'dir', 'file', or 'junction' (default is 'file'). It is only used on Windows (ignored on other platforms). Note that Windows junction points require the destination JsString path to be absolute. When using 'junction', the destination argument will automatically be normalized to absolute JsString path.
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <param name="type"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object symlink(JsString srcPath, JsString dstPath, JsString type, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronous symlink(2). No arguments other than a possible exception are given to the completion callback. type argument can be either 'dir', 'file', or 'junction' (default is 'file'). It is only used on Windows (ignored on other platforms). Note that Windows junction points require the destination JsString path to be absolute. When using 'junction', the destination argument will automatically be normalized to absolute JsString path.
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object symlink(JsString srcPath, JsString dstPath, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous symlink(2). 
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        public object symlinkSync(JsString srcPath, JsString dstPath) { return null; }
        /// <summary>
        /// Synchronous symlink(2).
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object symlinkSync(JsString srcPath, JsString dstPath, JsString type) { return null; }
        /// <summary>
        /// Asynchronous readlink(2). The callback gets two arguments (err, linkString).
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object readlink(JsString path) { return null; }
        /// <summary>
        /// Asynchronous readlink(2). The callback gets two arguments (err, linkString).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object readlink(JsString path, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// Synchronous readlink(2). Returns the symbolic link's string value. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object readlinkSync(JsString path) { return null; }
        /// <summary>
        /// Asynchronous realJsString path(2). The callback gets two arguments (err, resolvedJsString path). May use process.cwd to resolve relative JsString paths. cache is an object literal of mapped JsString paths that can be used to force a specific JsString path resolution or avoid additional fs.stat calls for known real JsString paths. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var cache = {'/etc':'/private/etc'};
        /// fs.realpath('/etc/passwd', cache, function (err, resolvedPath) {
        ///   if (err) throw err;
        ///   console.log(resolvedPath);
        /// });
        /// </code>
        /// </example>
        public object realPath(JsString path, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// Asynchronous realJsString path(2). The callback gets two arguments (err, resolvedJsString path). 
        /// May use process.cwd to resolve relative JsString paths. 
        /// cache is an object literal of mapped JsString paths that can be used to force a specific JsString path resolution or avoid additional fs.stat calls for known real JsString paths.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cache"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object realPath(JsString path, object cache, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// Synchronous realJsString path(2). Returns the resolved JsString path. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public JsString realPathSync(JsString path) { return null; }
        /// <summary>
        /// Synchronous realJsString path(2). Returns the resolved JsString path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cache"></param>
        /// <returns></returns>
        public JsString realPathSync(JsString path, object cache) { return null; }
        /// <summary>
        /// Asynchronous unlink(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object unlink(JsString path) { return null; }
        /// <summary>
        /// Asynchronous unlink(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object unlink(JsString path, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous unlink(2). 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object unlinkSync(JsString path) { return null; }
        /// <summary>
        /// Asynchronous rmdir(2). No arguments other than a possible exception are given to the completion callback. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object rmdir(JsString path) { return null; }
        /// <summary>
        /// Asynchronous rmdir(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object rmdir(JsString path, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous rmdir(2). 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object rmdirSync(JsString path) { return null; }
        /// <summary>
        /// Asynchronous mkdir(2). No arguments other than a possible exception are given to the completion callback. mode defaults to 0777. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object mkdir(JsString path) { return null; }
        /// <summary>
        /// Asynchronous mkdir(2). No arguments other than a possible exception are given to the completion callback. mode defaults to 0777.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object mkdir(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous mkdir(2). No arguments other than a possible exception are given to the completion callback. mode defaults to 0777.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object mkdir(JsString path, JsAction<JsError> callback) { return null; }
        /// <summary>
        /// Asynchronous mkdir(2). No arguments other than a possible exception are given to the completion callback. mode defaults to 0777.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object mkdir(JsString path, JsString mode, JsAction<JsError> callback) { return null; }
        /// <summary>
        /// Synchronous mkdir(2). 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object mkdirSync(JsString path) { return null; }
        /// <summary>
        /// Synchronous mkdir(2).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object mkdirSync(JsString path, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous readdir(3). Reads the contents of a directory.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object readdir(JsString path) { return null; }
        /// <summary>
        /// Asynchronous readdir(3). Reads the contents of a directory. 
        /// The callback gets two arguments (err, files) where files is an array of the names of the files in the directory excluding '.' and '..'.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object readdir(JsString path, JsAction<JsError, JsArray> callback) { return null; }
        /// <summary>
        /// Synchronous readdir(3). Returns an array of filenames excluding '.' and '..'. 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public JsArray readdirSync(JsString path) { return null; }
        /// <summary>
        /// Asynchronous close(2). No arguments other than a possible exception are given to the completion callback. 
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public object close(object fd) { return null; }
        /// <summary>
        /// Asynchronous close(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public object close(object fd, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous close(2). 
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public object closeSync(object fd) { return null; }
        //        //
        //        Asynchronous file open. See open(2). flags can be:

        /// 'r' - Open file for reading. An exception occurs if the file does not exist.
        /// 'r+' - Open file for reading and writing. An exception occurs if the file does not exist.
        /// 'rs' - Open file for reading in synchronous mode. Instructs the operating system to bypass the local file system cache.
        /// This is primarily useful for opening files on NFS mounts as it allows you to skip the potentially stale local cache. It has a very real impact on I/O performance so don't use this mode unless you need it.

        //Note that this doesn't turn fs.open() into a synchronous blocking call. If that's what you want then you should be using fs.openSync()

        //'rs+' - Open file for reading and writing, telling the OS to open it synchronously. See notes for 'rs' about using this with caution.
        //'w' - Open file for writing. The file is created (if it does not exist) or truncated (if it exists).
        //'wx' - Like 'w' but opens the file in exclusive mode.
        //'w+' - Open file for reading and writing. The file is created (if it does not exist) or truncated (if it exists).
        //'wx+' - Like 'w+' but opens the file in exclusive mode.
        //'a' - Open file for appending. The file is created if it does not exist.
        //'ax' - Like 'a' but opens the file in exclusive mode.
        //'a+' - Open file for reading and appending. The file is created if it does not exist.
        //'ax+' - Like 'a+' but opens the file in exclusive mode.
        //mode defaults to 0666. The callback gets two arguments (err, fd).

        //Exclusive mode (O_EXCL) ensures that path is newly created. fs.open() fails if a file by that name already exists. On POSIX systems, symlinks are not followed. Exclusive mode may or may not work with network file systems.
        /// <summary>
        /// Asynchronous file open.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">flags can be:
        /// <list type="bullet">
        /// <item>'r' - Open file for reading. An exception occurs if the file does not exist.</item>
        /// <item>'r+' - Open file for reading and writing. An exception occurs if the file does not exist.</item>
        /// <item>'rs' - Open file for reading in synchronous mode. Instructs the operating system to bypass the local file system cache.</item>
        /// This is primarily useful for opening files on NFS mounts as it allows you to skip the potentially stale local cache. 
        /// It has a very real impact on I/O performance so don't use this mode unless you need it.</list></param>
        /// Note that this doesn't turn fs.open() into a synchronous blocking call. If that's what you want then you should be using fs.openSync()
        /// <returns></returns>
        public object open(JsString path, JsString flags) { return null; }
        /// <summary>
        /// Asynchronous file open.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">flags can be:
        /// <list type="bullet">
        /// <item>'r' - Open file for reading. An exception occurs if the file does not exist.</item>
        /// <item>'r+' - Open file for reading and writing. An exception occurs if the file does not exist.</item>
        /// <item>'rs' - Open file for reading in synchronous mode. Instructs the operating system to bypass the local file system cache.</item>
        /// This is primarily useful for opening files on NFS mounts as it allows you to skip the potentially stale local cache. 
        /// It has a very real impact on I/O performance so don't use this mode unless you need it.</list></param>
        /// Note that this doesn't turn fs.open() into a synchronous blocking call. If that's what you want then you should be using fs.openSync()</param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object open(JsString path, JsString flags, JsString mode) { return null; }
        /// <summary>
        /// Asynchronous file open.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">flags can be:
        /// <list type="bullet">
        /// <item>'r' - Open file for reading. An exception occurs if the file does not exist.</item>
        /// <item>'r+' - Open file for reading and writing. An exception occurs if the file does not exist.</item>
        /// <item>'rs' - Open file for reading in synchronous mode. Instructs the operating system to bypass the local file system cache.</item>
        /// This is primarily useful for opening files on NFS mounts as it allows you to skip the potentially stale local cache. 
        /// It has a very real impact on I/O performance so don't use this mode unless you need it.</list></param>
        /// Note that this doesn't turn fs.open() into a synchronous blocking call. If that's what you want then you should be using fs.openSync()
        /// <param name="callback"></param>
        /// <returns></returns>
        public object open(JsString path, JsString flags, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronous file open.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">flags can be:
        /// <list type="bullet">
        /// <item>'r' - Open file for reading. An exception occurs if the file does not exist.</item>
        /// <item>'r+' - Open file for reading and writing. An exception occurs if the file does not exist.</item>
        /// <item>'rs' - Open file for reading in synchronous mode. Instructs the operating system to bypass the local file system cache.</item>
        /// This is primarily useful for opening files on NFS mounts as it allows you to skip the potentially stale local cache. 
        /// It has a very real impact on I/O performance so don't use this mode unless you need it.</list></param>
        /// Note that this doesn't turn fs.open() into a synchronous blocking call. If that's what you want then you should be using fs.openSync()
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object open(JsString path, JsString flags, JsString mode, JsAction callback) { return null; }
        /// <summary>
        /// Synchronous open(2). 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">
        /// <list type="bullet">
        /// <item>'rs+' - Open file for reading and writing, telling the OS to open it synchronously. See notes for 'rs' about using this with caution.</item>
        /// <item> 'w' - Open file for writing. The file is created (if it does not exist) or truncated (if it exists).</item>
        /// <item> 'wx' - Like 'w' but opens the file in exclusive mode.</item>
        /// <item> 'w+' - Open file for reading and writing. The file is created (if it does not exist) or truncated (if it exists).</item>
        /// <item> 'wx+' - Like 'w+' but opens the file in exclusive mode.</item>
        /// <item> 'a' - Open file for appending. The file is created if it does not exist.</item>
        /// <item> 'ax' - Like 'a' but opens the file in exclusive mode.</item>
        /// <item> 'a+' - Open file for reading and appending. The file is created if it does not exist.</item>
        /// <item> 'ax+' - Like 'a+' but opens the file in exclusive mode.</item>
        /// <item> mode defaults to 0666. The callback gets two arguments (err, fd).</item>
        /// </list>
        /// </param>
        /// <returns></returns>
        /// Exclusive mode (O_EXCL) ensures that path is newly created. fs.open() fails if a file by that name already exists. 
        /// On POSIX systems, symlinks are not followed. Exclusive mode may or may not work with network file systems.
        public object openSync(JsString path, JsString flags) { return null; }
        /// <summary>
        /// Synchronous open(2).
        /// </summary>
        /// <param name="path"></param>
        /// <param name="flags">
        /// <list type="bullet">
        /// <item>'rs+' - Open file for reading and writing, telling the OS to open it synchronously. See notes for 'rs' about using this with caution.</item>
        /// <item> 'w' - Open file for writing. The file is created (if it does not exist) or truncated (if it exists).</item>
        /// <item> 'wx' - Like 'w' but opens the file in exclusive mode.</item>
        /// <item> 'w+' - Open file for reading and writing. The file is created (if it does not exist) or truncated (if it exists).</item>
        /// <item> 'wx+' - Like 'w+' but opens the file in exclusive mode.</item>
        /// <item> 'a' - Open file for appending. The file is created if it does not exist.</item>
        /// <item> 'ax' - Like 'a' but opens the file in exclusive mode.</item>
        /// <item> 'a+' - Open file for reading and appending. The file is created if it does not exist.</item>
        /// <item> 'ax+' - Like 'a+' but opens the file in exclusive mode.</item>
        /// <item> mode defaults to 0666. The callback gets two arguments (err, fd).</item>
        /// </list>
        /// </param>
        /// <param name="mode"></param>
        /// <returns></returns>
        /// Exclusive mode (O_EXCL) ensures that path is newly created. fs.open() fails if a file by that name already exists. 
        /// On POSIX systems, symlinks are not followed. Exclusive mode may or may not work with network file systems.
        public object openSync(JsString path, JsString flags, JsString mode) { return null; }
        /// <summary>
        /// Change file timestamps of the file referenced by the supplied JsString path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <returns></returns>
        public object utimes(JsString path, DateTime atime, DateTime mtime) { return null; }
        /// <summary>
        /// Change file timestamps of the file referenced by the supplied JsString path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object utimes(JsString path, DateTime atime, DateTime mtime, JsAction callback) { return null; }
        /// <summary>
        /// Change file timestamps of the file referenced by the supplied JsString path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <returns></returns>
        public object utimesSync(JsString path, DateTime atime, DateTime mtime) { return null; }
        /// <summary>
        /// Change the file timestamps of a file referenced by the supplied file descriptor. 
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <returns></returns>
        public object futimes(object fd, DateTime atime, DateTime mtime) { return null; }
        /// <summary>
        /// Change the file timestamps of a file referenced by the supplied file descriptor.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object futimes(object fd, DateTime atime, DateTime mtime, JsAction callback) { return null; }
        /// <summary>
        /// Change the file timestamps of a file referenced by the supplied file descriptor.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="atime"></param>
        /// <param name="mtime"></param>
        /// <returns></returns>
        public object futimesSync(object fd, DateTime atime, DateTime mtime) { return null; }
        /// <summary>
        /// Asynchronous fsync(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public object fsync(object fd) { return null; }
        /// <summary>
        /// Asynchronous fsync(2). No arguments other than a possible exception are given to the completion callback.
        /// </summary>
        /// <param name="fd"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object fsync(object fd, JsAction<JsError> callback) { return null; }
        /// <summary>
        /// Synchronous fsync(2). 
        /// </summary>
        /// <param name="fd"></param>
        /// <returns></returns>
        public object fsyncSync(object fd) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <returns></returns>
        public object writeFile(JsString filename, JsString data) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <param name="encoding">The encoding argument is ignored if data is a buffer. It defaults to 'utf8'. </param>
        /// <returns></returns>
        public object writeFile(JsString filename, JsString data, JsString encoding) { return null; }
        public object writeFile(JsString filename, JsString data, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <param name="encoding">The encoding argument is ignored if data is a buffer. It defaults to 'utf8'. </param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object writeFile(JsString filename, JsString data, JsString encoding, JsAction callback) { return null; }
        public object writeFile(JsString filename, Buffer data) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <param name="encoding">The encoding argument is ignored if data is a buffer. It defaults to 'utf8'. </param>
        /// <returns></returns>
        public object writeFile(JsString filename, Buffer data, JsString encoding) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object writeFile(JsString filename, Buffer data, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronously writes data to a file, replacing the file if it already exists. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data">data can be a string or a buffer.</param>
        /// <param name="encoding">The encoding argument is ignored if data is a buffer. It defaults to 'utf8'. </param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// fs.writeFile('message.txt', 'Hello Node', function (err) {
        ///   if (err) throw err;
        ///   console.log('It\'s saved!');
        // });
        /// </code>
        /// </example>
        public object writeFile(JsString filename, Buffer data, JsString encoding, JsAction callback) { return null; }
        /// <summary>
        /// The synchronous version of fs.writeFile.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public object writeFileSync(JsString filename, JsString data) { return null; }
        /// <summary>
        /// The synchronous version of fs.writeFile.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public object writeFileSync(JsString filename, Buffer data) { return null; }
        /// <summary>
        /// The synchronous version of fs.writeFile.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public object writeFileSync(JsString filename, JsString data, object encoding) { return null; }
        /// <summary>
        /// The synchronous version of fs.writeFile.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public object writeFileSync(JsString filename, Buffer data, object encoding) { return null; }
        /// <summary>
        /// Asynchronously append data to a file, creating the file if it not yet exists. data can be a string or a buffer. The encoding argument is ignored if data is a buffer.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// fs.appendFile('message.txt', 'data to append', function (err) {
        ///   if (err) throw err;
        ///   console.log('The "data to append" was appended to file!');
        /// });
        /// </code>
        /// </example>
        public object appendFile(JsString filename, JsString data, object encoding) { return null; }
        /// <summary>
        /// Asynchronously append data to a file, creating the file if it not yet exists. data can be a string or a buffer. The encoding argument is ignored if data is a buffer.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// fs.appendFile('message.txt', 'data to append', function (err) {
        ///   if (err) throw err;
        ///   console.log('The "data to append" was appended to file!');
        /// });
        /// </code>
        /// </example>
        public object appendFile(JsString filename, Buffer data, object encoding) { return null; }
        /// <summary>
        /// Asynchronously append data to a file, creating the file if it not yet exists. data can be a string or a buffer. The encoding argument is ignored if data is a buffer.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// fs.appendFile('message.txt', 'data to append', function (err) {
        ///   if (err) throw err;
        ///   console.log('The "data to append" was appended to file!');
        /// });
        /// </code>
        /// </example>
        public object appendFile(JsString filename, JsString data, object encoding, JsAction callback) { return null; }
        /// <summary>
        /// Asynchronously append data to a file, creating the file if it not yet exists. data can be a string or a buffer. The encoding argument is ignored if data is a buffer.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// fs.appendFile('message.txt', 'data to append', function (err) {
        ///   if (err) throw err;
        ///   console.log('The "data to append" was appended to file!');
        /// });
        /// </code>
        /// </example>
        public object appendFile(JsString filename, Buffer data, object encoding, JsAction callback) { return null; }
        /// <summary>
        /// The synchronous version of fs.appendFile. 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public object appendFileSync(String filename, Buffer data, object encoding) { return null; }
        //

        //fs.watchFile(filename, [options], listener) { return null; }
        //Stability: 2 - Unstable.  Use fs.watch instead, if possible.
        //Watch for changes on filename. The callback listener will be called each time the file is accessed.

        //The second argument is optional. The options if provided should be an object containing two members a boolean, persistent, and interval. persistent indicates whether the process should continue to run as long as files are being watched. interval indicates how often the target should be polled, in milliseconds. The default is { persistent: true, interval: 5007 }.

        //The listener gets two arguments the current stat object and the previous stat object:

        //fs.watchFile('message.text', function (curr, prev) {
        //  console.log('the current mtime is: ' + curr.mtime);
        //  console.log('the previous mtime was: ' + prev.mtime);
        //});
        //These stat objects are instances of fs.Stat.

        //If you want to be notified when the file was modified, not just accessed you need to compare curr.mtime and prev.mtime.

        //fs.unwatchFile(filename, [listener]) { return null; }
        //Stability: 2 - Unstable.  Use fs.watch instead, if available.
        //Stop watching for changes on filename. If listener is specified, only that particular listener is removed. Otherwise, all listeners are removed and you have effectively stopped watching filename.

        //Calling fs.unwatchFile() with a filename that is not being watched is a no-op, not an error.

        //fs.watch(filename, [options], [listener]) { return null; }
        //Stability: 2 - Unstable.
        //Watch for changes on filename, where filename is either a file or a directory. The returned object is a fs.FSWatcher.

        //The second argument is optional. The options if provided should be an object containing a boolean member persistent, which indicates whether the process should continue to run as long as files are being watched. The default is { persistent: true }.

        //The listener callback gets two arguments (event, filename). event is either 'rename' or 'change', and filename is the name of the file which triggered the event.

        //Caveats { return null; }
        //The fs.watch API is not 100% consistent across platforms, and is unavailable in some situations.

        //Availability { return null; }

        //This feature depends on the underlying operating system providing a way to be notified of filesystem changes.

        //On Linux systems, this uses inotify.
        //On BSD systems (including OS X), this uses kqueue.
        //On SunOS systems (including Solaris and SmartOS), this uses event ports.
        //On Windows systems, this feature depends on ReadDirectoryChangesW.
        //If the underlying functionality is not available for some reason, then fs.watch will not be able to function. For example, watching files or directories on network file systems (NFS, SMB, etc.) often doesn't work reliably or at all.

        //You can still use fs.watchFile, which uses stat polling, but it is slower and less reliable.

        //Filename Argument { return null; }

        //Providing filename argument in the callback is not supported on every platform (currently it's only supported on Linux and Windows). Even on supported platforms filename is not always guaranteed to be provided. Therefore, don't assume that filename argument is always provided in the callback, and have some fallback logic if it is null.

        //fs.watch('somedir', function (event, filename) {
        //  console.log('event is: ' + event);
        //  if (filename) {
        //    console.log('filename provided: ' + filename);
        //  } else {
        //    console.log('filename not provided');
        //  }
        //});
        //fs.exists(path, [callback]) { return null; }
        //Test whether or not the given path exists by checking with the file system. Then call the callback argument with either true or false. Example:

        //fs.exists('/etc/passwd', function (exists) {
        //  util.debug(exists ? "it's there" : "no passwd!");
        //});
        //fs.existsSync(path) { return null; }
        //Synchronous version of fs.exists.

        //Class: fs.Stats { return null; }
        //Objects returned from fs.stat(), fs.lstat() and fs.fstat() and their synchronous counterparts are of this type.

        //stats.isFile()
        //stats.isDirectory()
        //stats.isBlockDevice()
        //stats.isCharacterDevice()
        //stats.isSymbolicLink() (only valid with fs.lstat())
        //stats.isFIFO()
        //stats.isSocket()
        //For a regular file util.inspect(stats) would return a string very similar to this:

        //{ dev: 2114,
        //  ino: 48064969,
        //  mode: 33188,
        //  nlink: 1,
        //  uid: 85,
        //  gid: 100,
        //  rdev: 0,
        //  size: 527,
        //  blksize: 4096,
        //  blocks: 8,
        //  atime: Mon, 10 Oct 2011 23:24:11 GMT,
        //  mtime: Mon, 10 Oct 2011 23:24:11 GMT,
        //  ctime: Mon, 10 Oct 2011 23:24:11 GMT }
        //Please note that atime, mtime and ctime are instances of Date object and to compare the values of these objects you should use appropriate methods. For most general uses getTime() will return the number of milliseconds elapsed since 1 January 1970 00:00:00 UTC and this integer should be sufficient for any comparison, however there additional methods which can be used for displaying fuzzy information. More details can be found in the MDN JavaScript Reference page.

        //fs.createReadStream(path, [options]) { return null; }
        //Returns a new ReadStream object (See Readable Stream).

        //options is an object with the following defaults:

        //{ flags: 'r',
        //  encoding: null,
        //  fd: null,
        //  mode: 0666,
        //  bufferSize: 64 * 1024
        //}
        //options can include start and end values to read a range of bytes from the file instead of the entire file. Both start and end are inclusive and start at 0. The encoding can be 'utf8', 'ascii', or 'base64'.

        //An example to read the last 10 bytes of a file which is 100 bytes long:

        //fs.createReadStream('sample.txt', {start: 90, end: 99});
    }
}
