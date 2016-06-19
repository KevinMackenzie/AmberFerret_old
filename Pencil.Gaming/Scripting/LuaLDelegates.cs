using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security;

namespace Pencil.Gaming.Scripting {
	internal static unsafe class LuaLDelegates {
		static LuaLDelegates() {
#if DEBUG
			Stopwatch sw = new Stopwatch();
			sw.Start();
#endif
			Type luaInterop = (IntPtr.Size == 8) ? typeof(LuaL64) : typeof(LuaL32);
#if DEBUG
			Console.WriteLine("LuaL interop: {0}", luaInterop.Name);
#endif
			FieldInfo[] fields = typeof(LuaLDelegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			foreach (FieldInfo fi in fields) {
				MethodInfo mi = luaInterop.GetMethod(fi.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
				Delegate function = mi.CreateDelegate(fi.FieldType);
				fi.SetValue(null, function);
			}
#if DEBUG
			sw.Stop();
			Console.WriteLine("Copying LuaL delegates took {0} milliseconds.", sw.ElapsedMilliseconds);
#endif
		}

		
		internal delegate void checkversion_(LuaStatePtr l,double ver);
		
		internal delegate int getmetafield(LuaStatePtr l,int obj,[MarshalAs(UnmanagedType.LPStr)] string e);
		
		internal delegate int callmeta(LuaStatePtr l,int obj,[MarshalAs(UnmanagedType.LPStr)] string e);
		
		internal delegate sbyte * tolstring(LuaStatePtr l,int idx,int *len);
		
		internal delegate int argerror(LuaStatePtr l,int numarg,[MarshalAs(UnmanagedType.LPStr)] string extramsg);
		
		internal delegate sbyte * checklstring(LuaStatePtr l,int numArg,int * l_);
		
		internal delegate sbyte * optlstring(LuaStatePtr l,int numArg,[MarshalAs(UnmanagedType.LPStr)] string def,int * l_);
		
		internal delegate double checknumber(LuaStatePtr l,int numArg);
		
		internal delegate double optnumber(LuaStatePtr l,int nArg,double def);
		
		internal delegate int checkinteger(LuaStatePtr l,int numArg);
		
		internal delegate int optinteger(LuaStatePtr l,int nArg,int def);
		
		internal delegate uint checkunsigned(LuaStatePtr l,int numArg);
		
		internal delegate uint optunsigned(LuaStatePtr l,int numArg,uint def);
		
		internal delegate void checkstack(LuaStatePtr l,int sz,[MarshalAs(UnmanagedType.LPStr)] string msg);
		
		internal delegate void checktype(LuaStatePtr l,int narg,int t);
		
		internal delegate void checkany(LuaStatePtr l,int narg);
		
		internal delegate int newmetatable(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string tname);
		
		internal delegate void setmetatable(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string tname);
		
		internal delegate IntPtr testudata(LuaStatePtr l,int ud,[MarshalAs(UnmanagedType.LPStr)] string tname);
		
		internal delegate IntPtr checkudata(LuaStatePtr l,int ud,[MarshalAs(UnmanagedType.LPStr)] string tname);
		
		internal delegate void @where(LuaStatePtr l,int lvl);
		
		internal delegate int checkoption(LuaStatePtr l,int narg,[MarshalAs(UnmanagedType.LPStr)] string def,[MarshalAs(UnmanagedType.LPArray)] sbyte *[] lst);
		
		internal delegate int fileresult(LuaStatePtr l,int stat,[MarshalAs(UnmanagedType.LPStr)] string fname);
		
		internal delegate int execresult(LuaStatePtr l,int stat);
		
		internal delegate int @ref(LuaStatePtr l,int t);
		
		internal delegate void unref(LuaStatePtr l,int t,int @ref);
		
		internal delegate int loadfilex(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string filename,[MarshalAs(UnmanagedType.LPStr)] string mode);
		
		internal delegate int loadbufferx(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string buff,int sz,[MarshalAs(UnmanagedType.LPStr)] string name,[MarshalAs(UnmanagedType.LPStr)] string mode);
		
		internal delegate int loadstring(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string s);
		
		internal delegate LuaStatePtr newstate();
		
		internal delegate int len(LuaStatePtr l,int idx);
		
		internal delegate sbyte * gsub(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string s,[MarshalAs(UnmanagedType.LPStr)] string p,[MarshalAs(UnmanagedType.LPStr)] string r);
		
		internal delegate void setfuncs(LuaStatePtr l,IntPtr l_,int nup);
		
		internal delegate int getsubtable(LuaStatePtr l,int idx,[MarshalAs(UnmanagedType.LPStr)] string fname);
		
		internal delegate void traceback(LuaStatePtr l,LuaStatePtr l1,[MarshalAs(UnmanagedType.LPStr)] string msg,int level);
		
		internal delegate void requiref(LuaStatePtr l,[MarshalAs(UnmanagedType.LPStr)] string modname,LuaCFunction openf,int glb);
		
		internal delegate void buffinit(LuaStatePtr l,LuaBufferPtr B);
		
		internal delegate sbyte *prepbuffsize(LuaBufferPtr B,int sz);
		
		internal delegate void addlstring(LuaBufferPtr B,[MarshalAs(UnmanagedType.LPStr)] string s,int l);
		
		internal delegate void addstring(LuaBufferPtr B,[MarshalAs(UnmanagedType.LPStr)] string s);
		
		internal delegate void addvalue(LuaBufferPtr B);
		
		internal delegate void pushresult(LuaBufferPtr B);
		
		internal delegate void pushresultsize(LuaBufferPtr B,int sz);
		
		internal delegate sbyte *buffinitsize(LuaStatePtr l,LuaBufferPtr B,int sz);
		
		internal delegate void openlibs(LuaStatePtr l);

		#pragma warning disable 0649

		internal static checkversion_ luaL_checkversion_;
		internal static getmetafield luaL_getmetafield;
		internal static callmeta luaL_callmeta;
		internal static tolstring luaL_tolstring;
		internal static argerror luaL_argerror;
		internal static checklstring luaL_checklstring;
		internal static optlstring luaL_optlstring;
		internal static checknumber luaL_checknumber;
		internal static optnumber luaL_optnumber;
		internal static checkinteger luaL_checkinteger;
		internal static optinteger luaL_optinteger;
		internal static checkunsigned luaL_checkunsigned;
		internal static optunsigned luaL_optunsigned;
		internal static checkstack luaL_checkstack;
		internal static checktype luaL_checktype;
		internal static checkany luaL_checkany;
		internal static newmetatable luaL_newmetatable;
		internal static setmetatable luaL_setmetatable;
		internal static testudata luaL_testudata;
		internal static checkudata luaL_checkudata;
		internal static @where luaL_where;
		internal static checkoption luaL_checkoption;
		internal static fileresult luaL_fileresult;
		internal static execresult luaL_execresult;
		internal static @ref luaL_ref;
		internal static unref luaL_unref;
		internal static loadfilex luaL_loadfilex;
		internal static loadbufferx luaL_loadbufferx;
		internal static loadstring luaL_loadstring;
		internal static newstate luaL_newstate;
		internal static len luaL_len;
		internal static gsub luaL_gsub;
		internal static setfuncs luaL_setfuncs;
		internal static getsubtable luaL_getsubtable;
		internal static traceback luaL_traceback;
		internal static requiref luaL_requiref;
		internal static buffinit luaL_buffinit;
		internal static prepbuffsize luaL_prepbuffsize;
		internal static addlstring luaL_addlstring;
		internal static addstring luaL_addstring;
		internal static addvalue luaL_addvalue;
		internal static pushresult luaL_pushresult;
		internal static pushresultsize luaL_pushresultsize;
		internal static buffinitsize luaL_buffinitsize;
		internal static openlibs luaL_openlibs;

		#pragma warning restore 0649
	}
}

