﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asn1f2 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Asn1f2.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;stdio.h&gt;
        ///#include &lt;string.h&gt;
        ///#include &lt;assert.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &lt;float.h&gt;
        ///
        ///#include &quot;asn1crt.h&quot;
        ///
        ///extern byte masksb[];
        ///extern byte masks[];
        ///
        ///
        ///
        ///flag RequiresReverse() 
        ///{
        ///	short int word = 0x0001; 
        ///	char *byte = (char *) &amp;word; 
        ///	return byte[0] == 1;
        ///}
        ///
        ///
        ///
        ///asn1SccUint int2uint(asn1SccSint v);
        ///asn1SccSint uint2int(asn1SccUint v, int uintSizeInBytes);
        ///
        ///
        ///void Acn_AlignToNextByte(BitStream* pBitStrm) 
        ///{
        ///	if (pBitStrm-&gt;currentBit != 0) 
        ///	{
        ///		pBitStrm-&gt;currentBit=0;
        ///		pBitStrm-&gt;currentByte++;
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Acn {
            get {
                return ResourceManager.GetString("Acn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with Interfaces;
        ///with Ada.Unchecked_Conversion;
        ///use type Interfaces.Unsigned_8;
        ///use type Interfaces.Integer_8;
        ///use type Interfaces.Unsigned_64;
        ///use type Interfaces.Integer_64;
        ///
        ///PACKAGE BODY adaasn1rtl IS
        ///
        ///
        ///
        ///
        ///    MASKS : CONSTANT OctetBuffer_8 := OctetBuffer_8&apos;(16#80#, 16#40#, 16#20#, 16#10#, 16#08#, 16#04#, 16#02#, 16#01#);
        ///--    MSBIT_ONE  : CONSTANT Asn1UInt := Asn1UInt(2)**(Asn1UInt&apos;SIZE - 1);
        ///    MSBIT_ONE  : CONSTANT Asn1UInt := 16#8000000000000000#;
        ///
        ///    MSBYTE_FF  : CONSTANT Asn1UInt: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string adaasn1rtl_adb {
            get {
                return ResourceManager.GetString("adaasn1rtl_adb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH Ada.Characters.Latin_1;
        ///WITH Interfaces;
        ///--# inherit Ada.Characters.Latin_1,
        ///--#         Interfaces;
        ///
        ///
        ///PACKAGE adaasn1rtl
        ///
        ///IS
        ///
        ///
        ///
        ///
        ///    SUBTYPE RANGE_1_4 is Natural range 1..4;
        ///    SUBTYPE RANGE_1_8 is Natural range 1..8;
        ///    SUBTYPE RANGE_1_100 is Natural range 1..100;
        ///
        ///
        ///    TYPE BIT IS mod 2**1;
        ///    TYPE BitArray IS ARRAY (Natural  RANGE &lt;&gt;) OF BIT;
        ///    for BitArray&apos;Component_Size use 1;
        ///    pragma Pack(BitArray);
        ///
        ///    SUBTYPE Asn1Byte IS Interfaces.Unsigned_8;
        ///    TYPE OctetBuf [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string adaasn1rtl_ads {
            get {
                return ResourceManager.GetString("adaasn1rtl_ads", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;string.h&gt;
        ///#include &lt;assert.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &lt;float.h&gt;
        ///
        ///#include &quot;asn1crt.h&quot;
        ///
        ///
        ///byte masks[] = {0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01};
        ///byte masksb[] = {0x0, 0x1, 0x3, 0x7, 0xF, 0x1F, 0x3F, 0x7F, 0xFF};
        ///
        ///asn1SccUint32 masks2[] = {0x0, 0xFF, 
        ///						0xFF00, 
        ///						0xFF0000, 
        ///						0xFF000000
        ///					};
        ///#if WORD_SIZE==8
        ///asn1SccUint64 masks2b[] = {0x0, 0xFF, 
        ///						0xFF00, 
        ///						0xFF0000, 
        ///						0xFF000000, 
        ///						0xFF00000000ULL, 
        ///						0xFF0000000000ULL, 
        ///						0xFF000000000000ULL, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string asn1crt {
            get {
                return ResourceManager.GetString("asn1crt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #ifndef _INC_PER_UTIL_H
        ///#define _INC_PER_UTIL_H
        ///
        ///
        ///#ifdef  __cplusplus
        ///extern &quot;C&quot; {
        ///#endif
        ///
        ///#ifndef NULL
        ///#define NULL	0
        ///#endif
        ///
        ///#ifndef TRUE
        ///#define TRUE	1
        ///#endif
        ///
        ///#ifndef FALSE
        ///#define FALSE	0
        ///#endif
        ///
        ///
        ///#ifndef WORD_SIZE
        ///#define WORD_SIZE	8
        ///#endif
        ///
        ///typedef int asn1SccSint32;
        ///typedef unsigned int asn1SccUint32;
        ///
        ///typedef unsigned char byte;
        ///
        ///
        ///#if WORD_SIZE==8
        ///typedef long long asn1SccSint64;
        ///typedef unsigned long long asn1SccUint64;
        ///typedef asn1SccUint64 asn1SccUint;
        ///typedef asn1SccSint64 asn1SccSint;
        ///#else
        ///ty [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string asn1crt1 {
            get {
                return ResourceManager.GetString("asn1crt1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;stdio.h&gt;
        ///#include &lt;string.h&gt;
        ///#include &lt;assert.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &lt;float.h&gt;
        ///#include &lt;ctype.h&gt;
        ///#include &lt;stdlib.h&gt;
        ///
        ///
        ///#include &quot;asn1crt.h&quot;
        ///
        ///
        ///#if WORD_SIZE==8
        ///asn1SccUint64 ber_aux[] = {
        ///						0xFF, 
        ///						0xFF00, 
        ///						0xFF0000, 
        ///						0xFF000000, 
        ///						0xFF00000000ULL, 
        ///						0xFF0000000000ULL, 
        ///						0xFF000000000000ULL, 
        ///						0xFF00000000000000ULL};
        ///#else
        ///asn1SccUint32 ber_aux[] = {
        ///						0xFF, 
        ///						0xFF00, 
        ///						0xFF0000, 
        ///						0xFF000000};
        ///
        ///#endif
        ///
        ///
        /////defined in asn1crt.c
        ///int  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ber {
            get {
                return ResourceManager.GetString("ber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package Standard is
        ///   type Integer is range -2147483648 ..  2147483647;
        ///   type Float is digits  6 range -3.40282E+38 ..  3.40282E+38;
        ///   type Short_Short_Integer is range -128 ..  127;
        ///   type Short_Integer is range -32768 ..  32767;
        ///   type Long_Integer is range -9223372036854775808 ..  9223372036854775807;
        ///
        ///   type Short_Float is digits  6 range -3.40282E+38 ..  3.40282E+38;
        ///   type Long_Float is digits  15 range -1.79769313486232E+308 ..  1.79769313486232E+308;
        ///end Standard;
        ///
        ///
        ///package Syste [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gnat {
            get {
                return ResourceManager.GetString("gnat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to project GPS_project is
        ///
        ///   for Object_Dir use &quot;bin&quot;;
        ///   for Main use (&quot;mainprogram.adb&quot;);
        ///
        ///   package Ide is
        ///      for Default_Switches (&quot;examiner&quot;) use (&quot;-vcg&quot;, &quot;-dpc&quot;, &quot;-sparklib&quot;, &quot;-language=2005&quot;, &quot;-index_file=spark.idx&quot;,
        ///         &quot;-warning_file=IgnoredExaminerWarnings.wrn&quot;, &quot;-config=gnat.cfg&quot;,
        ///         &quot;-output_directory=examiner&quot;);
        ///      for Default_Switches (&quot;sparksimp&quot;) use (&quot;-p=4&quot;, &quot;-nz&quot;, &quot;-victor&quot;);
        ///   end Ide;
        ///
        ///end GPS_project;
        ///
        ///.
        /// </summary>
        internal static string GPS_project {
            get {
                return ResourceManager.GetString("GPS_project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to representation_clauses
        ///pragma all
        ///hidden_parts
        ///declare_annotations
        ///real_rtcs.
        /// </summary>
        internal static string IgnoredExaminerWarnings {
            get {
                return ResourceManager.GetString("IgnoredExaminerWarnings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;assert.h&gt;
        ///#include &lt;float.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &quot;asn1crt.h&quot;
        ///
        ///#if WORD_SIZE==8
        ///#define MAX_MANTISSA 4503599627370496
        ///#else
        ///#define MAX_MANTISSA 2147483648
        ///#endif
        ///
        ///#if WORD_SIZE==8
        ///#define MANTISSA_FACTOR 4503599627370496.0
        ///#define EXPONENET_FACTOR 52
        ///#else
        ///#define MANTISSA_FACTOR 4294967296.0
        ///#define EXPONENET_FACTOR 32
        ///
        ///#endif
        ///
        ///
        ///
        ///#ifndef FREXP_UNSUPPORTED
        ///
        ///#define ExpoBitMask  0x7FF0000000000000ULL
        ///#define MantBitMask  0x000FFFFFFFFFFFFFULL
        ///#define MantBitMask2 0xFFE0000000000000ULL
        ///
        ///void  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string real {
            get {
                return ResourceManager.GetString("real", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;assert.h&gt;
        ///#include &lt;float.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &quot;asn1crt.h&quot;
        ///
        ///#if WORD_SIZE==8
        ///#define MAX_MANTISSA 4503599627370496
        ///#else
        ///#define MAX_MANTISSA 2147483648
        ///#endif
        ///
        ///#if WORD_SIZE==8
        ///#define MANTISSA_FACTOR 4503599627370496.0
        ///#define EXPONENET_FACTOR 52
        ///#else
        ///#define MANTISSA_FACTOR 4294967296.0
        ///#define EXPONENET_FACTOR 32
        ///
        ///#endif
        ///
        ///
        ///
        ///#ifndef FREXP_UNSUPPORTED
        ///
        ///#define ExpoBitMask  0x7FF0000000000000ULL
        ///#define MantBitMask  0x000FFFFFFFFFFFFFULL
        ///#define MantBitMask2 0xFFE0000000000000ULL
        ///
        ///void  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string real1 {
            get {
                return ResourceManager.GetString("real1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #!/bin/bash
        ///rm -rf examiner/*
        ///#sparkmake || exit 1
        ///
        ///
        ///for file in $(ls *.adb)
        ///do
        ///    if [ &quot;$file&quot; == &quot;mainprogram.adb&quot; -o &quot;$file&quot; == &quot;adaasn1rtl.adb&quot; ] ; then
        ///	continue
        ///    fi
        ///    #spark -sparklib -output=examiner -conf=gnat.cfg -vcg -dpc -i=spark.idx  -language=2005 -warning_file=IgnoredExaminerWarnings.wrn $file
        ///    spark -sparklib -output=examiner -conf=gnat.cfg -vcg -i=spark.idx  -language=2005 -warning_file=IgnoredExaminerWarnings.wrn $file
        ///	if [ $? -ne 0 -a $? -ne 1 ] ; then
        ///	    exit 1
        ///	fi
        ///done
        ///
        ///spark [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string run {
            get {
                return ResourceManager.GetString("run", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &lt;stdio.h&gt;
        ///#include &lt;string.h&gt;
        ///#include &lt;assert.h&gt;
        ///#include &lt;math.h&gt;
        ///#include &lt;float.h&gt;
        ///#include &lt;ctype.h&gt;
        ///#include &lt;stdlib.h&gt;
        ///
        ///
        ///#include &quot;asn1crt.h&quot;
        ///
        ///
        ///
        ///char* Int2String(asn1SccSint v) {
        ///	static char tmp[256];
        ///#if WORD_SIZE==8
        ///	sprintf(tmp,&quot;%lld&quot;,v);
        ///#else
        ///	sprintf(tmp,&quot;%ld&quot;,v);
        ///#endif
        ///
        ///	return tmp;
        ///}
        ///
        ///char* Double2String(double v) {
        ///	static char tmp[256];
        ///	char* pos1 = NULL;
        ///	sprintf(tmp,&quot;%#.12E&quot;,v);
        ///
        ///	pos1 = strchr(tmp,&apos;+&apos;);
        ///	if (pos1!=NULL) {
        ///		*pos1=0x0;
        ///		strcat(tmp, ++pos1);
        ///	}
        ///
        ///
        ///	return tmp;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string xer {
            get {
                return ResourceManager.GetString("xer", resourceCulture);
            }
        }
    }
}
