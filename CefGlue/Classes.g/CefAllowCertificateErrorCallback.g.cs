//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefAllowCertificateErrorCallback : IDisposable
    {
        internal static CefAllowCertificateErrorCallback FromNative(cef_allow_certificate_error_callback_t* ptr)
        {
            return new CefAllowCertificateErrorCallback(ptr);
        }
        
        internal static CefAllowCertificateErrorCallback FromNativeOrNull(cef_allow_certificate_error_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefAllowCertificateErrorCallback(ptr);
        }
        
        private cef_allow_certificate_error_callback_t* _self;
        
        private CefAllowCertificateErrorCallback(cef_allow_certificate_error_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefAllowCertificateErrorCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_allow_certificate_error_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_allow_certificate_error_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_allow_certificate_error_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_allow_certificate_error_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
