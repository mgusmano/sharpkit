using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Exceptions
{
    [JsType(JsMode.Prototype)]
    class Class1
    {
        void Foo()
        {
            try
            {
            }
            catch
            {
                throw;
            }
            try
            {
            }
            catch(Exception)
            {
                throw;
            }

            try
            {
            }
            catch (Exception e)
            {
                throw;
            }
            try
            {
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
