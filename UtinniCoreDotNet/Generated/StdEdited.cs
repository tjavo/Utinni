// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UtinniCore")]

namespace Std
{
    namespace BasicString
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1 _Mypair;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("UtinniCore-Symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint = "??0?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@XZ")]
            internal static extern global::System.IntPtr ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("UtinniCore-Symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint = "??1?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@XZ")]
            internal static extern void dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr __instance, int delete);
        }
    }

    public unsafe partial class BasicString<_Elem, _Traits, _Alloc> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>>();

        protected bool __ownsNativeInstance;

        internal static global::Std.BasicString<_Elem, _Traits, _Alloc> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_Elem, _Traits, _Alloc>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.BasicString<_Elem, _Traits, _Alloc> __CreateInstance(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_Elem, _Traits, _Alloc>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
            *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*)ret = native;
            return ret.ToPointer();
        }

        private BasicString(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public BasicString()
        {
            var ___Elem = typeof(_Elem);
            var ___Traits = typeof(_Traits);
            var ___Alloc = typeof(_Alloc);
            if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.ctorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.BasicString<_Elem, _Traits, _Alloc> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
            {
                var ___Elem = typeof(_Elem);
                var ___Traits = typeof(_Traits);
                var ___Alloc = typeof(_Alloc);
                if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
                {
                    global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C.dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(__Instance, 0);
                    return;
                }
                throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    namespace StringVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internalc__N_std_S__String_val____N_std_S__Simple_types__C
        {
            [FieldOffset(0)]
            internal global::Std.StringVal.Bxty.__Internal _Bx;

            [FieldOffset(16)]
            internal uint _Mysize;

            [FieldOffset(20)]
            internal uint _Myres;
        }

        namespace Bxty
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal fixed sbyte _Buf[16];

                [FieldOffset(0)]
                internal global::System.IntPtr _Ptr;

                [FieldOffset(0)]
                internal fixed sbyte _Alias[16];
            }
        }

    }

    namespace CharTraits
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_Elem> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>>();

        protected bool __ownsNativeInstance;

        internal static global::Std.CharTraits<_Elem> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_Elem>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.CharTraits<_Elem> __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_Elem>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.CharTraits<_Elem> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    public unsafe static partial class BasicStringExtensions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("UtinniCore-Symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint = "?assign@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAEAAV12@QBD@Z")]
            internal static extern global::System.IntPtr Assign(global::System.IntPtr __instance, [MarshalAs(UnmanagedType.LPUTF8Str)] string _Ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("UtinniCore-Symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint = "?data@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBEPBDXZ")]
            internal static extern global::System.IntPtr Data(global::System.IntPtr __instance);
        }

        public static global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> Assign(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this, string _Ptr)
        {
            var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.Assign(__arg0, _Ptr);
            global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>)global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap[__ret];
            else __result0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
            return __result0;
        }

        public static string Data(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this)
        {
            var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.Data(__arg0);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace CompressedPair
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.StringVal.__Internalc__N_std_S__String_val____N_std_S__Simple_types__C _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_less____N_INI_S_Value___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1__S1___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S5__Vb1_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_INI_S_Value_S3___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1 _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_INI_S_Value_S3___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.TreeVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1_____N_INI_S_Section__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_INI_S_Section__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1 _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_INI_S_Section__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.TreeVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1____N_INI_S_Value__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_INI_S_Value__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1 _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_INI_S_Value__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.TreeVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1__S1___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_S3___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1 _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_S3___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.TreeVal.__Internal _Myval2;
        }
    }

    namespace Allocator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("UtinniCore-Symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint = "??0?$allocator@D@std@@QAE@XZ")]
            internal static extern global::System.IntPtr ctorc__N_std_S_allocator__C(global::System.IntPtr __instance);
        }
    }

    public unsafe partial class Allocator<_Ty> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>>();

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator<_Ty> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Ty>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator<_Ty> __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Ty>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Allocator()
        {
            var ___Ty = typeof(_Ty);
            if (___Ty.IsAssignableFrom(typeof(sbyte)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.Allocator.__Internal.ctorc__N_std_S_allocator__C(__Instance);
                return;
            }
            throw new ArgumentOutOfRangeException("_Ty", string.Join(", ", new[] { typeof(_Ty).FullName }), "global::Std.Allocator<_Ty> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.Allocator<_Ty> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S_map____N_INI_S_Value_S0____N_std_S_less__S0____N_std_S_allocator____N_std_S_pair__1S0__S0_
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_less____N_INI_S_Value___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1__S1___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S5__Vb1_Vb1 _Mypair;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S_map____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_INI_S_Section___N_std_S_less__S0____N_std_S_allocator____N_std_S_pair__1S0__S3_
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1_____N_INI_S_Section__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1 _Mypair;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S_map____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_INI_S_Value___N_std_S_less__S0____N_std_S_allocator____N_std_S_pair__1S0__S3_
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1____N_INI_S_Value__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1 _Mypair;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S_map____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_S0____N_std_S_less__S0____N_std_S_allocator____N_std_S_pair__1S0__S0_
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1__S1___v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1 _Mypair;
        }
    }
}

namespace Std
{
    namespace TreeVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _Myhead;

            [FieldOffset(4)]
            internal uint _Mysize;
        }
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
    namespace BasicStringbuf
    {
        [StructLayout(LayoutKind.Explicit, Size = 68)]
        public unsafe partial struct __Internalc__N_std_S_basic_stringbuf__C___N_std_S_char_traits__C___N_std_S_allocator__C
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_basic_streambuf;

            [FieldOffset(4)]
            internal global::System.IntPtr _Gfirst;

            [FieldOffset(8)]
            internal global::System.IntPtr _Pfirst;

            [FieldOffset(12)]
            internal global::System.IntPtr _IGfirst;

            [FieldOffset(16)]
            internal global::System.IntPtr _IPfirst;

            [FieldOffset(20)]
            internal global::System.IntPtr _Gnext;

            [FieldOffset(24)]
            internal global::System.IntPtr _Pnext;

            [FieldOffset(28)]
            internal global::System.IntPtr _IGnext;

            [FieldOffset(32)]
            internal global::System.IntPtr _IPnext;

            [FieldOffset(36)]
            internal int _Gcount;

            [FieldOffset(40)]
            internal int _Pcount;

            [FieldOffset(44)]
            internal global::System.IntPtr _IGcount;

            [FieldOffset(48)]
            internal global::System.IntPtr _IPcount;

            [FieldOffset(52)]
            internal global::System.IntPtr _Plocale;

            [FieldOffset(56)]
            internal global::System.IntPtr _Seekhigh;

            [FieldOffset(60)]
            internal int _Mystate;

            [FieldOffset(64)]
            internal global::Std.Allocator.__Internal _Al;
        }
    }
}