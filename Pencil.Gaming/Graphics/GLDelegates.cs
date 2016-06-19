#region License
// Copyright (c) 2013 Antonie Blom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Pencil.Gaming.Graphics {
	#pragma warning disable 0649
	#pragma warning disable 3019
	#pragma warning disable 1591

	partial class GL {
		internal static partial class Delegates {
			
			internal delegate void Accum(Pencil.Gaming.Graphics.AccumOp op,Single value);
			internal static Accum glAccum;
			
			internal delegate void ActiveShaderProgram(UInt32 pipeline,UInt32 program);
			internal static ActiveShaderProgram glActiveShaderProgram;
			
			internal delegate void ActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
			internal static ActiveTexture glActiveTexture;
			
			internal delegate void AlphaFunc(Pencil.Gaming.Graphics.AlphaFunction func,Single @ref);
			internal static AlphaFunc glAlphaFunc;
			
			internal unsafe delegate bool AreTexturesResident(Int32 n,UInt32* textures,[OutAttribute] bool* residences);
			internal unsafe static AreTexturesResident glAreTexturesResident;
			
			internal delegate void ArrayElement(Int32 i);
			internal static ArrayElement glArrayElement;
			
			internal delegate void AttachShader(UInt32 program,UInt32 shader);
			internal static AttachShader glAttachShader;
			
			internal delegate void Begin(Pencil.Gaming.Graphics.BeginMode mode);
			internal static Begin glBegin;
			
			internal delegate void BeginConditionalRender(UInt32 id,Pencil.Gaming.Graphics.ConditionalRenderType mode);
			internal static BeginConditionalRender glBeginConditionalRender;
			
			internal delegate void BeginQuery(Pencil.Gaming.Graphics.QueryTarget target,UInt32 id);
			internal static BeginQuery glBeginQuery;
			
			internal delegate void BeginQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index,UInt32 id);
			internal static BeginQueryIndexed glBeginQueryIndexed;
			
			internal delegate void BeginTransformFeedback(Pencil.Gaming.Graphics.BeginFeedbackMode primitiveMode);
			internal static BeginTransformFeedback glBeginTransformFeedback;
			
			internal delegate void BindAttribLocation(UInt32 program,UInt32 index,String name);
			internal static BindAttribLocation glBindAttribLocation;
			
			internal delegate void BindBuffer(Pencil.Gaming.Graphics.BufferTarget target,UInt32 buffer);
			internal static BindBuffer glBindBuffer;
			
			internal delegate void BindBufferBase(Pencil.Gaming.Graphics.BufferTarget target,UInt32 index,UInt32 buffer);
			internal static BindBufferBase glBindBufferBase;
			
			internal delegate void BindBufferRange(Pencil.Gaming.Graphics.BufferTarget target,UInt32 index,UInt32 buffer,IntPtr offset,IntPtr size);
			internal static BindBufferRange glBindBufferRange;
			
			internal delegate void BindFragDataLocation(UInt32 program,UInt32 color,String name);
			internal static BindFragDataLocation glBindFragDataLocation;
			
			internal delegate void BindFragDataLocationIndexed(UInt32 program,UInt32 colorNumber,UInt32 index,String name);
			internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;
			
			internal delegate void BindFramebuffer(Pencil.Gaming.Graphics.FramebufferTarget target,UInt32 framebuffer);
			internal static BindFramebuffer glBindFramebuffer;
			
			internal delegate void BindProgramPipeline(UInt32 pipeline);
			internal static BindProgramPipeline glBindProgramPipeline;
			
			internal delegate void BindRenderbuffer(Pencil.Gaming.Graphics.RenderbufferTarget target,UInt32 renderbuffer);
			internal static BindRenderbuffer glBindRenderbuffer;
			
			internal delegate void BindSampler(UInt32 unit,UInt32 sampler);
			internal static BindSampler glBindSampler;
			
			internal delegate void BindTexture(Pencil.Gaming.Graphics.TextureTarget target,UInt32 texture);
			internal static BindTexture glBindTexture;
			
			internal delegate void BindTransformFeedback(Pencil.Gaming.Graphics.TransformFeedbackTarget target,UInt32 id);
			internal static BindTransformFeedback glBindTransformFeedback;
			
			internal delegate void BindVertexArray(UInt32 array);
			internal static BindVertexArray glBindVertexArray;
			
			internal unsafe delegate void Bitmap(Int32 width,Int32 height,Single xorig,Single yorig,Single xmove,Single ymove,Byte* bitmap);
			internal unsafe static Bitmap glBitmap;
			
			internal delegate void BlendColor(Single red,Single green,Single blue,Single alpha);
			internal static BlendColor glBlendColor;
			
			internal delegate void BlendEquation(Pencil.Gaming.Graphics.BlendEquationMode mode);
			internal static BlendEquation glBlendEquation;
			
			internal delegate void BlendEquationi(UInt32 buf,Pencil.Gaming.Graphics.Version40 mode);
			internal static BlendEquationi glBlendEquationi;
			
			internal delegate void BlendEquationSeparate(Pencil.Gaming.Graphics.BlendEquationMode modeRGB,Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
			internal static BlendEquationSeparate glBlendEquationSeparate;
			
			internal delegate void BlendEquationSeparatei(UInt32 buf,Pencil.Gaming.Graphics.BlendEquationMode modeRGB,Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
			internal static BlendEquationSeparatei glBlendEquationSeparatei;
			
			internal delegate void BlendFunc(Pencil.Gaming.Graphics.BlendingFactorSrc sfactor,Pencil.Gaming.Graphics.BlendingFactorDest dfactor);
			internal static BlendFunc glBlendFunc;
			
			internal delegate void BlendFunci(UInt32 buf,Pencil.Gaming.Graphics.Version40 src,Pencil.Gaming.Graphics.Version40 dst);
			internal static BlendFunci glBlendFunci;
			
			internal delegate void BlendFuncSeparate(Pencil.Gaming.Graphics.BlendingFactorSrc sfactorRGB,Pencil.Gaming.Graphics.BlendingFactorDest dfactorRGB,Pencil.Gaming.Graphics.BlendingFactorSrc sfactorAlpha,Pencil.Gaming.Graphics.BlendingFactorDest dfactorAlpha);
			internal static BlendFuncSeparate glBlendFuncSeparate;
			
			internal delegate void BlendFuncSeparatei(UInt32 buf,Pencil.Gaming.Graphics.Version40 srcRGB,Pencil.Gaming.Graphics.Version40 dstRGB,Pencil.Gaming.Graphics.Version40 srcAlpha,Pencil.Gaming.Graphics.Version40 dstAlpha);
			internal static BlendFuncSeparatei glBlendFuncSeparatei;
			//
			//internal delegate void BlendFuncSeparateINGR(Pencil.Gaming.Graphics.All sfactorRGB,Pencil.Gaming.Graphics.All dfactorRGB,Pencil.Gaming.Graphics.All sfactorAlpha,Pencil.Gaming.Graphics.All dfactorAlpha);
			//internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR;
			
			internal delegate void BlitFramebuffer(Int32 srcX0,Int32 srcY0,Int32 srcX1,Int32 srcY1,Int32 dstX0,Int32 dstY0,Int32 dstX1,Int32 dstY1,Pencil.Gaming.Graphics.ClearBufferMask mask,Pencil.Gaming.Graphics.BlitFramebufferFilter filter);
			internal static BlitFramebuffer glBlitFramebuffer;
			
			internal delegate void BufferData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr size,IntPtr data,Pencil.Gaming.Graphics.BufferUsageHint usage);
			internal static BufferData glBufferData;
			
			internal delegate void BufferSubData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr size,IntPtr data);
			internal static BufferSubData glBufferSubData;
			
			internal delegate void CallList(UInt32 list);
			internal static CallList glCallList;
			
			internal delegate void CallLists(Int32 n,Pencil.Gaming.Graphics.ListNameType type,IntPtr lists);
			internal static CallLists glCallLists;
			
			internal delegate Pencil.Gaming.Graphics.FramebufferErrorCode CheckFramebufferStatus(Pencil.Gaming.Graphics.FramebufferTarget target);
			internal static CheckFramebufferStatus glCheckFramebufferStatus;
			
			internal delegate void ClampColor(Pencil.Gaming.Graphics.ClampColorTarget target,Pencil.Gaming.Graphics.ClampColorMode clamp);
			internal static ClampColor glClampColor;
			
			internal delegate void Clear(Pencil.Gaming.Graphics.ClearBufferMask mask);
			internal static Clear glClear;
			
			internal delegate void ClearAccum(Single red,Single green,Single blue,Single alpha);
			internal static ClearAccum glClearAccum;
			
			internal delegate void ClearBufferfi(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Single depth,Int32 stencil);
			internal static ClearBufferfi glClearBufferfi;
			
			internal unsafe delegate void ClearBufferfv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Single* value);
			internal unsafe static ClearBufferfv glClearBufferfv;
			
			internal unsafe delegate void ClearBufferiv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Int32* value);
			internal unsafe static ClearBufferiv glClearBufferiv;
			
			internal unsafe delegate void ClearBufferuiv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,UInt32* value);
			internal unsafe static ClearBufferuiv glClearBufferuiv;
			
			internal delegate void ClearColor(Single red,Single green,Single blue,Single alpha);
			internal static ClearColor glClearColor;
			
			internal delegate void ClearDepth(Double depth);
			internal static ClearDepth glClearDepth;
			
			internal delegate void ClearDepthf(Single d);
			internal static ClearDepthf glClearDepthf;
			
			internal delegate void ClearIndex(Single c);
			internal static ClearIndex glClearIndex;
			
			internal delegate void ClearStencil(Int32 s);
			internal static ClearStencil glClearStencil;
			
			internal delegate void ClientActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
			internal static ClientActiveTexture glClientActiveTexture;
			
			internal delegate Pencil.Gaming.Graphics.ArbSync ClientWaitSync(IntPtr sync,UInt32 flags,UInt64 timeout);
			internal static ClientWaitSync glClientWaitSync;
			
			internal unsafe delegate void ClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane,Double* equation);
			internal unsafe static ClipPlane glClipPlane;
			
			internal delegate void Color3b(SByte red,SByte green,SByte blue);
			internal static Color3b glColor3b;
			
			internal unsafe delegate void Color3bv(SByte* v);
			internal unsafe static Color3bv glColor3bv;
			
			internal delegate void Color3d(Double red,Double green,Double blue);
			internal static Color3d glColor3d;
			
			internal unsafe delegate void Color3dv(Double* v);
			internal unsafe static Color3dv glColor3dv;
			
			internal delegate void Color3f(Single red,Single green,Single blue);
			internal static Color3f glColor3f;
			
			internal unsafe delegate void Color3fv(Single* v);
			internal unsafe static Color3fv glColor3fv;
			
			internal delegate void Color3i(Int32 red,Int32 green,Int32 blue);
			internal static Color3i glColor3i;
			
			internal unsafe delegate void Color3iv(Int32* v);
			internal unsafe static Color3iv glColor3iv;
			
			internal delegate void Color3s(Int16 red,Int16 green,Int16 blue);
			internal static Color3s glColor3s;
			
			internal unsafe delegate void Color3sv(Int16* v);
			internal unsafe static Color3sv glColor3sv;
			
			internal delegate void Color3ub(Byte red,Byte green,Byte blue);
			internal static Color3ub glColor3ub;
			
			internal unsafe delegate void Color3ubv(Byte* v);
			internal unsafe static Color3ubv glColor3ubv;
			
			internal delegate void Color3ui(UInt32 red,UInt32 green,UInt32 blue);
			internal static Color3ui glColor3ui;
			
			internal unsafe delegate void Color3uiv(UInt32* v);
			internal unsafe static Color3uiv glColor3uiv;
			
			internal delegate void Color3us(UInt16 red,UInt16 green,UInt16 blue);
			internal static Color3us glColor3us;
			
			internal unsafe delegate void Color3usv(UInt16* v);
			internal unsafe static Color3usv glColor3usv;
			
			internal delegate void Color4b(SByte red,SByte green,SByte blue,SByte alpha);
			internal static Color4b glColor4b;
			
			internal unsafe delegate void Color4bv(SByte* v);
			internal unsafe static Color4bv glColor4bv;
			
			internal delegate void Color4d(Double red,Double green,Double blue,Double alpha);
			internal static Color4d glColor4d;
			
			internal unsafe delegate void Color4dv(Double* v);
			internal unsafe static Color4dv glColor4dv;
			
			internal delegate void Color4f(Single red,Single green,Single blue,Single alpha);
			internal static Color4f glColor4f;
			
			internal unsafe delegate void Color4fv(Single* v);
			internal unsafe static Color4fv glColor4fv;
			
			internal delegate void Color4i(Int32 red,Int32 green,Int32 blue,Int32 alpha);
			internal static Color4i glColor4i;
			
			internal unsafe delegate void Color4iv(Int32* v);
			internal unsafe static Color4iv glColor4iv;
			
			internal delegate void Color4s(Int16 red,Int16 green,Int16 blue,Int16 alpha);
			internal static Color4s glColor4s;
			
			internal unsafe delegate void Color4sv(Int16* v);
			internal unsafe static Color4sv glColor4sv;
			
			internal delegate void Color4ub(Byte red,Byte green,Byte blue,Byte alpha);
			internal static Color4ub glColor4ub;
			
			internal unsafe delegate void Color4ubv(Byte* v);
			internal unsafe static Color4ubv glColor4ubv;
			
			internal delegate void Color4ui(UInt32 red,UInt32 green,UInt32 blue,UInt32 alpha);
			internal static Color4ui glColor4ui;
			
			internal unsafe delegate void Color4uiv(UInt32* v);
			internal unsafe static Color4uiv glColor4uiv;
			
			internal delegate void Color4us(UInt16 red,UInt16 green,UInt16 blue,UInt16 alpha);
			internal static Color4us glColor4us;
			
			internal unsafe delegate void Color4usv(UInt16* v);
			internal unsafe static Color4usv glColor4usv;
			
			internal delegate void ColorMask(bool red,bool green,bool blue,bool alpha);
			internal static ColorMask glColorMask;
			
			internal delegate void ColorMaski(UInt32 index,bool r,bool g,bool b,bool a);
			internal static ColorMaski glColorMaski;
			
			internal delegate void ColorMaterial(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.ColorMaterialParameter mode);
			internal static ColorMaterial glColorMaterial;
			
			internal delegate void ColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
			internal static ColorP3ui glColorP3ui;
			
			internal unsafe delegate void ColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
			internal unsafe static ColorP3uiv glColorP3uiv;
			
			internal delegate void ColorP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
			internal static ColorP4ui glColorP4ui;
			
			internal unsafe delegate void ColorP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
			internal unsafe static ColorP4uiv glColorP4uiv;
			
			internal delegate void ColorPointer(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer);
			internal static ColorPointer glColorPointer;
			
			
			internal delegate void ColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 count,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr data);
			internal static ColorSubTable glColorSubTable;
			
			internal delegate void ColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr table);
			internal static ColorTable glColorTable;
			
			internal unsafe delegate void ColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.ColorTableParameterPName pname,Single* @params);
			internal unsafe static ColorTableParameterfv glColorTableParameterfv;
			
			internal unsafe delegate void ColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.ColorTableParameterPName pname,Int32* @params);
			internal unsafe static ColorTableParameteriv glColorTableParameteriv;
			
			internal delegate void CompileShader(UInt32 shader);
			internal static CompileShader glCompileShader;
			
			internal delegate void CompressedTexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 border,Int32 imageSize,IntPtr data);
			internal static CompressedTexImage1D glCompressedTexImage1D;
			
			internal delegate void CompressedTexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 border,Int32 imageSize,IntPtr data);
			internal static CompressedTexImage2D glCompressedTexImage2D;
			
			internal delegate void CompressedTexImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Int32 imageSize,IntPtr data);
			internal static CompressedTexImage3D glCompressedTexImage3D;
			
			internal delegate void CompressedTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
			internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
			
			internal delegate void CompressedTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
			internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
			
			internal delegate void CompressedTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
			internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
			
			internal delegate void ConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
			internal static ConvolutionFilter1D glConvolutionFilter1D;
			
			internal delegate void ConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
			internal static ConvolutionFilter2D glConvolutionFilter2D;
			
			internal delegate void ConvolutionParameterf(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Single @params);
			internal static ConvolutionParameterf glConvolutionParameterf;
			
			internal unsafe delegate void ConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Single* @params);
			internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
			
			internal delegate void ConvolutionParameteri(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Int32 @params);
			internal static ConvolutionParameteri glConvolutionParameteri;
			
			internal unsafe delegate void ConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Int32* @params);
			internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
			
			internal delegate void CopyBufferSubData(Pencil.Gaming.Graphics.BufferTarget readTarget,Pencil.Gaming.Graphics.BufferTarget writeTarget,IntPtr readOffset,IntPtr writeOffset,IntPtr size);
			internal static CopyBufferSubData glCopyBufferSubData;
			
			internal delegate void CopyColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 x,Int32 y,Int32 width);
			internal static CopyColorSubTable glCopyColorSubTable;
			
			internal delegate void CopyColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
			internal static CopyColorTable glCopyColorTable;
			
			internal delegate void CopyConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
			internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
			
			internal delegate void CopyConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height);
			internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
			
			internal delegate void CopyPixels(Int32 x,Int32 y,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelCopyType type);
			internal static CopyPixels glCopyPixels;
			
			internal delegate void CopyTexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 border);
			internal static CopyTexImage1D glCopyTexImage1D;
			
			internal delegate void CopyTexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height,Int32 border);
			internal static CopyTexImage2D glCopyTexImage2D;
			
			internal delegate void CopyTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 x,Int32 y,Int32 width);
			internal static CopyTexSubImage1D glCopyTexSubImage1D;
			
			internal delegate void CopyTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 x,Int32 y,Int32 width,Int32 height);
			internal static CopyTexSubImage2D glCopyTexSubImage2D;
			
			internal delegate void CopyTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 x,Int32 y,Int32 width,Int32 height);
			internal static CopyTexSubImage3D glCopyTexSubImage3D;
			
			internal delegate UInt32 CreateProgram();
			internal static CreateProgram glCreateProgram;
			
			internal delegate UInt32 CreateShader(Pencil.Gaming.Graphics.ShaderType type);
			internal static CreateShader glCreateShader;
			
			internal delegate UInt32 CreateShaderProgramv(Pencil.Gaming.Graphics.ShaderType type,Int32 count,String[] strings);
			internal static CreateShaderProgramv glCreateShaderProgramv;
			
			internal delegate void CullFace(Pencil.Gaming.Graphics.CullFaceMode mode);
			internal static CullFace glCullFace;
			
			internal unsafe delegate void DeleteBuffers(Int32 n,UInt32* buffers);
			internal unsafe static DeleteBuffers glDeleteBuffers;
			
			internal unsafe delegate void DeleteFramebuffers(Int32 n,UInt32* framebuffers);
			internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
			
			internal delegate void DeleteLists(UInt32 list,Int32 range);
			internal static DeleteLists glDeleteLists;
			
			internal delegate void DeleteProgram(UInt32 program);
			internal static DeleteProgram glDeleteProgram;
			
			internal unsafe delegate void DeleteProgramPipelines(Int32 n,UInt32* pipelines);
			internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines;
			
			internal unsafe delegate void DeleteQueries(Int32 n,UInt32* ids);
			internal unsafe static DeleteQueries glDeleteQueries;
			
			internal unsafe delegate void DeleteRenderbuffers(Int32 n,UInt32* renderbuffers);
			internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
			
			internal unsafe delegate void DeleteSamplers(Int32 count,UInt32* samplers);
			internal unsafe static DeleteSamplers glDeleteSamplers;
			
			internal delegate void DeleteShader(UInt32 shader);
			internal static DeleteShader glDeleteShader;
			
			internal delegate void DeleteSync(IntPtr sync);
			internal static DeleteSync glDeleteSync;
			
			internal unsafe delegate void DeleteTextures(Int32 n,UInt32* textures);
			internal unsafe static DeleteTextures glDeleteTextures;
			
			internal unsafe delegate void DeleteTransformFeedbacks(Int32 n,UInt32* ids);
			internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
			
			internal unsafe delegate void DeleteVertexArrays(Int32 n,UInt32* arrays);
			internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
			
			internal delegate void DepthFunc(Pencil.Gaming.Graphics.DepthFunction func);
			internal static DepthFunc glDepthFunc;
			
			internal delegate void DepthMask(bool flag);
			internal static DepthMask glDepthMask;
			
			internal delegate void DepthRange(Double near,Double far);
			internal static DepthRange glDepthRange;
			
			internal unsafe delegate void DepthRangeArrayv(UInt32 first,Int32 count,Double* v);
			internal unsafe static DepthRangeArrayv glDepthRangeArrayv;
			
			internal delegate void DepthRangef(Single n,Single f);
			internal static DepthRangef glDepthRangef;
			
			internal delegate void DepthRangeIndexed(UInt32 index,Double n,Double f);
			internal static DepthRangeIndexed glDepthRangeIndexed;
			
			internal delegate void DetachShader(UInt32 program,UInt32 shader);
			internal static DetachShader glDetachShader;
			
			internal delegate void Disable(Pencil.Gaming.Graphics.EnableCap cap);
			internal static Disable glDisable;
			
			internal delegate void DisableClientState(Pencil.Gaming.Graphics.ArrayCap array);
			internal static DisableClientState glDisableClientState;
			
			internal delegate void Disablei(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
			internal static Disablei glDisablei;
			
			internal delegate void DisableVertexAttribArray(UInt32 index);
			internal static DisableVertexAttribArray glDisableVertexAttribArray;
			
			internal delegate void DrawArrays(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count);
			internal static DrawArrays glDrawArrays;
			
			internal delegate void DrawArraysIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode,IntPtr indirect);
			internal static DrawArraysIndirect glDrawArraysIndirect;
			
			internal delegate void DrawArraysInstanced(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count,Int32 primcount);
			internal static DrawArraysInstanced glDrawArraysInstanced;
			
			internal delegate void DrawBuffer(Pencil.Gaming.Graphics.DrawBufferMode mode);
			internal static DrawBuffer glDrawBuffer;
			
			internal unsafe delegate void DrawBuffers(Int32 n,Pencil.Gaming.Graphics.DrawBuffersEnum* bufs);
			internal unsafe static DrawBuffers glDrawBuffers;
			
			internal delegate void DrawElements(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices);
			internal static DrawElements glDrawElements;
			
			internal delegate void DrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 basevertex);
			internal static DrawElementsBaseVertex glDrawElementsBaseVertex;
			
			internal delegate void DrawElementsIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode,Pencil.Gaming.Graphics.ArbDrawIndirect type,IntPtr indirect);
			internal static DrawElementsIndirect glDrawElementsIndirect;
			
			internal delegate void DrawElementsInstanced(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
			internal static DrawElementsInstanced glDrawElementsInstanced;
			
			internal delegate void DrawElementsInstancedBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount,Int32 basevertex);
			internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
			
			internal delegate void DrawPixels(Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static DrawPixels glDrawPixels;
			
			internal delegate void DrawRangeElements(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices);
			internal static DrawRangeElements glDrawRangeElements;
			
			internal delegate void DrawRangeElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 basevertex);
			internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
			
			internal delegate void DrawTransformFeedback(Pencil.Gaming.Graphics.BeginMode mode,UInt32 id);
			internal static DrawTransformFeedback glDrawTransformFeedback;
			
			internal delegate void DrawTransformFeedbackStream(Pencil.Gaming.Graphics.BeginMode mode,UInt32 id,UInt32 stream);
			internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;
			
			internal delegate void EdgeFlag(bool flag);
			internal static EdgeFlag glEdgeFlag;
			
			internal delegate void EdgeFlagPointer(Int32 stride,IntPtr pointer);
			internal static EdgeFlagPointer glEdgeFlagPointer;
			
			internal unsafe delegate void EdgeFlagv(bool* flag);
			internal unsafe static EdgeFlagv glEdgeFlagv;
			
			internal delegate void Enable(Pencil.Gaming.Graphics.EnableCap cap);
			internal static Enable glEnable;
			
			internal delegate void EnableClientState(Pencil.Gaming.Graphics.ArrayCap array);
			internal static EnableClientState glEnableClientState;
			
			internal delegate void Enablei(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
			internal static Enablei glEnablei;
			
			internal delegate void EnableVertexAttribArray(UInt32 index);
			internal static EnableVertexAttribArray glEnableVertexAttribArray;
			
			internal delegate void End();
			internal static End glEnd;
			
			internal delegate void EndConditionalRender();
			internal static EndConditionalRender glEndConditionalRender;
			
			internal delegate void EndList();
			internal static EndList glEndList;
			
			internal delegate void EndQuery(Pencil.Gaming.Graphics.QueryTarget target);
			internal static EndQuery glEndQuery;
			
			internal delegate void EndQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index);
			internal static EndQueryIndexed glEndQueryIndexed;
			
			internal delegate void EndTransformFeedback();
			internal static EndTransformFeedback glEndTransformFeedback;
			
			internal delegate void EvalCoord1d(Double u);
			internal static EvalCoord1d glEvalCoord1d;
			
			internal unsafe delegate void EvalCoord1dv(Double* u);
			internal unsafe static EvalCoord1dv glEvalCoord1dv;
			
			internal delegate void EvalCoord1f(Single u);
			internal static EvalCoord1f glEvalCoord1f;
			
			internal unsafe delegate void EvalCoord1fv(Single* u);
			internal unsafe static EvalCoord1fv glEvalCoord1fv;
			
			internal delegate void EvalCoord2d(Double u,Double v);
			internal static EvalCoord2d glEvalCoord2d;
			
			internal unsafe delegate void EvalCoord2dv(Double* u);
			internal unsafe static EvalCoord2dv glEvalCoord2dv;
			
			internal delegate void EvalCoord2f(Single u,Single v);
			internal static EvalCoord2f glEvalCoord2f;
			
			internal unsafe delegate void EvalCoord2fv(Single* u);
			internal unsafe static EvalCoord2fv glEvalCoord2fv;
			
			internal delegate void EvalMesh1(Pencil.Gaming.Graphics.MeshMode1 mode,Int32 i1,Int32 i2);
			internal static EvalMesh1 glEvalMesh1;
			
			internal delegate void EvalMesh2(Pencil.Gaming.Graphics.MeshMode2 mode,Int32 i1,Int32 i2,Int32 j1,Int32 j2);
			internal static EvalMesh2 glEvalMesh2;
			
			internal delegate void EvalPoint1(Int32 i);
			internal static EvalPoint1 glEvalPoint1;
			
			internal delegate void EvalPoint2(Int32 i,Int32 j);
			internal static EvalPoint2 glEvalPoint2;
			
			internal unsafe delegate void FeedbackBuffer(Int32 size,Pencil.Gaming.Graphics.FeedbackType type,[OutAttribute] Single* buffer);
			internal unsafe static FeedbackBuffer glFeedbackBuffer;
			
			internal delegate IntPtr FenceSync(Pencil.Gaming.Graphics.ArbSync condition,UInt32 flags);
			internal static FenceSync glFenceSync;
			
			internal delegate void Finish();
			internal static Finish glFinish;
			
			internal delegate void Flush();
			internal static Flush glFlush;
			
			internal delegate void FlushMappedBufferRange(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr length);
			internal static FlushMappedBufferRange glFlushMappedBufferRange;
			
			internal delegate void FogCoordd(Double coord);
			internal static FogCoordd glFogCoordd;
			
			internal unsafe delegate void FogCoorddv(Double* coord);
			internal unsafe static FogCoorddv glFogCoorddv;
			
			internal delegate void FogCoordf(Single coord);
			internal static FogCoordf glFogCoordf;
			
			internal unsafe delegate void FogCoordfv(Single* coord);
			internal unsafe static FogCoordfv glFogCoordfv;
			
			internal delegate void FogCoordPointer(Pencil.Gaming.Graphics.FogPointerType type,Int32 stride,IntPtr pointer);
			internal static FogCoordPointer glFogCoordPointer;
			
			internal delegate void Fogf(Pencil.Gaming.Graphics.FogParameter pname,Single param);
			internal static Fogf glFogf;
			
			internal unsafe delegate void Fogfv(Pencil.Gaming.Graphics.FogParameter pname,Single* @params);
			internal unsafe static Fogfv glFogfv;
			
			internal delegate void Fogi(Pencil.Gaming.Graphics.FogParameter pname,Int32 param);
			internal static Fogi glFogi;
			
			internal unsafe delegate void Fogiv(Pencil.Gaming.Graphics.FogParameter pname,Int32* @params);
			internal unsafe static Fogiv glFogiv;
			
			internal delegate void FramebufferRenderbuffer(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget,UInt32 renderbuffer);
			internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
			
			internal delegate void FramebufferTexture(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level);
			internal static FramebufferTexture glFramebufferTexture;
			
			internal delegate void FramebufferTexture1D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
			internal static FramebufferTexture1D glFramebufferTexture1D;
			
			internal delegate void FramebufferTexture2D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
			internal static FramebufferTexture2D glFramebufferTexture2D;
			
			internal delegate void FramebufferTexture3D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level,Int32 zoffset);
			internal static FramebufferTexture3D glFramebufferTexture3D;
			
			internal delegate void FramebufferTextureLayer(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Int32 layer);
			internal static FramebufferTextureLayer glFramebufferTextureLayer;
			
			internal delegate void FrameTerminatorGREMEDY();
			internal static FrameTerminatorGREMEDY glFrameTerminatorGREMEDY;
			
			internal delegate void FrontFace(Pencil.Gaming.Graphics.FrontFaceDirection mode);
			internal static FrontFace glFrontFace;
			
			internal delegate void Frustum(Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
			internal static Frustum glFrustum;
			
			internal unsafe delegate void GenBuffers(Int32 n,[OutAttribute] UInt32* buffers);
			internal unsafe static GenBuffers glGenBuffers;
			
			internal delegate void GenerateMipmap(Pencil.Gaming.Graphics.GenerateMipmapTarget target);
			internal static GenerateMipmap glGenerateMipmap;
			
			internal unsafe delegate void GenFramebuffers(Int32 n,[OutAttribute] UInt32* framebuffers);
			internal unsafe static GenFramebuffers glGenFramebuffers;
			
			internal delegate Int32 GenLists(Int32 range);
			internal static GenLists glGenLists;
			
			internal unsafe delegate void GenProgramPipelines(Int32 n,[OutAttribute] UInt32* pipelines);
			internal unsafe static GenProgramPipelines glGenProgramPipelines;
			
			internal unsafe delegate void GenQueries(Int32 n,[OutAttribute] UInt32* ids);
			internal unsafe static GenQueries glGenQueries;
			
			internal unsafe delegate void GenRenderbuffers(Int32 n,[OutAttribute] UInt32* renderbuffers);
			internal unsafe static GenRenderbuffers glGenRenderbuffers;
			
			internal unsafe delegate void GenSamplers(Int32 count,[OutAttribute] UInt32* samplers);
			internal unsafe static GenSamplers glGenSamplers;
			
			internal unsafe delegate void GenTextures(Int32 n,[OutAttribute] UInt32* textures);
			internal unsafe static GenTextures glGenTextures;
			
			internal unsafe delegate void GenTransformFeedbacks(Int32 n,[OutAttribute] UInt32* ids);
			internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
			
			internal unsafe delegate void GenVertexArrays(Int32 n,[OutAttribute] UInt32* arrays);
			internal unsafe static GenVertexArrays glGenVertexArrays;
			
			internal unsafe delegate void GetActiveAttrib(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type,[OutAttribute] StringBuilder name);
			internal unsafe static GetActiveAttrib glGetActiveAttrib;
			
			internal unsafe delegate void GetActiveSubroutineName(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Int32 bufsize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder name);
			internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName;
			
			internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Pencil.Gaming.Graphics.ActiveSubroutineUniformParameter pname,[OutAttribute] Int32* values);
			internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
			
			internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Int32 bufsize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder name);
			internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
			
			internal unsafe delegate void GetActiveUniform(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveUniformType* type,[OutAttribute] StringBuilder name);
			internal unsafe static GetActiveUniform glGetActiveUniform;
			
			internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program,UInt32 uniformBlockIndex,Pencil.Gaming.Graphics.ActiveUniformBlockParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
			
			internal unsafe delegate void GetActiveUniformBlockName(UInt32 program,UInt32 uniformBlockIndex,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder uniformBlockName);
			internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
			
			internal unsafe delegate void GetActiveUniformName(UInt32 program,UInt32 uniformIndex,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder uniformName);
			internal unsafe static GetActiveUniformName glGetActiveUniformName;
			
			internal unsafe delegate void GetActiveUniformsiv(UInt32 program,Int32 uniformCount,UInt32* uniformIndices,Pencil.Gaming.Graphics.ActiveUniformParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
			
			internal unsafe delegate void GetAttachedShaders(UInt32 program,Int32 maxCount,[OutAttribute] Int32* count,[OutAttribute] UInt32* obj);
			internal unsafe static GetAttachedShaders glGetAttachedShaders;
			
			internal delegate Int32 GetAttribLocation(UInt32 program,String name);
			internal static GetAttribLocation glGetAttribLocation;
			
			internal unsafe delegate void GetBooleani_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] bool* data);
			internal unsafe static GetBooleani_v glGetBooleani_v;
			
			internal unsafe delegate void GetBooleanv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] bool* @params);
			internal unsafe static GetBooleanv glGetBooleanv;
			
			internal unsafe delegate void GetBufferParameteri64v(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferParameterName pname,[OutAttribute] Int64* @params);
			internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
			
			internal unsafe delegate void GetBufferParameteriv(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferParameterName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
			
			internal delegate void GetBufferPointerv(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferPointer pname,[OutAttribute] IntPtr @params);
			internal static GetBufferPointerv glGetBufferPointerv;
			
			internal delegate void GetBufferSubData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr size,[OutAttribute] IntPtr data);
			internal static GetBufferSubData glGetBufferSubData;
			
			internal unsafe delegate void GetClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane,[OutAttribute] Double* equation);
			internal unsafe static GetClipPlane glGetClipPlane;
			
			internal delegate void GetColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr table);
			internal static GetColorTable glGetColorTable;
			
			internal unsafe delegate void GetColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Single* @params);
			internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
			
			internal unsafe delegate void GetColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
			
			internal delegate void GetCompressedTexImage(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,[OutAttribute] IntPtr img);
			internal static GetCompressedTexImage glGetCompressedTexImage;
			
			internal delegate void GetConvolutionFilter(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr image);
			internal static GetConvolutionFilter glGetConvolutionFilter;
			
			internal unsafe delegate void GetConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.GetConvolutionParameterPName pname,[OutAttribute] Single* @params);
			internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
			
			internal unsafe delegate void GetConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.GetConvolutionParameterPName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
			
			internal unsafe delegate void GetDoublei_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Double* data);
			internal unsafe static GetDoublei_v glGetDoublei_v;
			
			internal unsafe delegate void GetDoublev(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Double* @params);
			internal unsafe static GetDoublev glGetDoublev;
			
			internal delegate Pencil.Gaming.Graphics.ErrorCode GetError();
			internal static GetError glGetError;
			
			internal unsafe delegate void GetFloati_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Single* data);
			internal unsafe static GetFloati_v glGetFloati_v;
			
			internal unsafe delegate void GetFloatv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Single* @params);
			internal unsafe static GetFloatv glGetFloatv;
			
			internal delegate Int32 GetFragDataIndex(UInt32 program,String name);
			internal static GetFragDataIndex glGetFragDataIndex;
			
			internal delegate Int32 GetFragDataLocation(UInt32 program,String name);
			internal static GetFragDataLocation glGetFragDataLocation;
			
			internal unsafe delegate void GetFramebufferAttachmentParameteriv(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.FramebufferParameterName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
			
			internal delegate void GetHistogram(Pencil.Gaming.Graphics.HistogramTarget target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
			internal static GetHistogram glGetHistogram;
			
			internal unsafe delegate void GetHistogramParameterfv(Pencil.Gaming.Graphics.HistogramTarget target,Pencil.Gaming.Graphics.GetHistogramParameterPName pname,[OutAttribute] Single* @params);
			internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
			
			internal unsafe delegate void GetHistogramParameteriv(Pencil.Gaming.Graphics.HistogramTarget target,Pencil.Gaming.Graphics.GetHistogramParameterPName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
			
			internal unsafe delegate void GetInteger64i_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Int64* data);
			internal unsafe static GetInteger64i_v glGetInteger64i_v;
			
			internal unsafe delegate void GetInteger64v(Pencil.Gaming.Graphics.ArbSync pname,[OutAttribute] Int64* @params);
			internal unsafe static GetInteger64v glGetInteger64v;
			
			internal unsafe delegate void GetIntegeri_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Int32* data);
			internal unsafe static GetIntegeri_v glGetIntegeri_v;
			
			internal unsafe delegate void GetIntegerv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetIntegerv glGetIntegerv;
			
			internal unsafe delegate void GetLightfv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetLightfv glGetLightfv;
			
			internal unsafe delegate void GetLightiv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetLightiv glGetLightiv;
			
			internal unsafe delegate void GetMapdv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Double* v);
			internal unsafe static GetMapdv glGetMapdv;
			
			internal unsafe delegate void GetMapfv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Single* v);
			internal unsafe static GetMapfv glGetMapfv;
			
			internal unsafe delegate void GetMapiv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Int32* v);
			internal unsafe static GetMapiv glGetMapiv;
			
			internal unsafe delegate void GetMaterialfv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetMaterialfv glGetMaterialfv;
			
			internal unsafe delegate void GetMaterialiv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetMaterialiv glGetMaterialiv;
			
			internal delegate void GetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
			internal static GetMinmax glGetMinmax;
			
			internal unsafe delegate void GetMinmaxParameterfv(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.GetMinmaxParameterPName pname,[OutAttribute] Single* @params);
			internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
			
			internal unsafe delegate void GetMinmaxParameteriv(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.GetMinmaxParameterPName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
			
			internal unsafe delegate void GetMultisamplefv(Pencil.Gaming.Graphics.GetMultisamplePName pname,UInt32 index,[OutAttribute] Single* val);
			internal unsafe static GetMultisamplefv glGetMultisamplefv;
			
			internal unsafe delegate void GetPixelMapfv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] Single* values);
			internal unsafe static GetPixelMapfv glGetPixelMapfv;
			
			internal unsafe delegate void GetPixelMapuiv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] UInt32* values);
			internal unsafe static GetPixelMapuiv glGetPixelMapuiv;
			
			internal unsafe delegate void GetPixelMapusv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] UInt16* values);
			internal unsafe static GetPixelMapusv glGetPixelMapusv;
			
			internal delegate void GetPointerv(Pencil.Gaming.Graphics.GetPointervPName pname,[OutAttribute] IntPtr @params);
			internal static GetPointerv glGetPointerv;
			
			internal unsafe delegate void GetPolygonStipple([OutAttribute] Byte* mask);
			internal unsafe static GetPolygonStipple glGetPolygonStipple;
			
			internal unsafe delegate void GetProgramBinary(UInt32 program,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Pencil.Gaming.Graphics.BinaryFormat* binaryFormat,[OutAttribute] IntPtr binary);
			internal unsafe static GetProgramBinary glGetProgramBinary;
			
			internal unsafe delegate void GetProgramInfoLog(UInt32 program,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
			internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
			
			internal unsafe delegate void GetProgramiv(UInt32 program,Pencil.Gaming.Graphics.ProgramParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetProgramiv glGetProgramiv;
			
			internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
			internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;
			
			internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline,Pencil.Gaming.Graphics.ProgramPipelineParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv;
			
			internal unsafe delegate void GetProgramStageiv(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,Pencil.Gaming.Graphics.ProgramStageParameter pname,[OutAttribute] Int32* values);
			internal unsafe static GetProgramStageiv glGetProgramStageiv;
			
			internal unsafe delegate void GetQueryIndexediv(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index,Pencil.Gaming.Graphics.GetQueryParam pname,[OutAttribute] Int32* @params);
			internal unsafe static GetQueryIndexediv glGetQueryIndexediv;
			
			internal unsafe delegate void GetQueryiv(Pencil.Gaming.Graphics.QueryTarget target,Pencil.Gaming.Graphics.GetQueryParam pname,[OutAttribute] Int32* @params);
			internal unsafe static GetQueryiv glGetQueryiv;
			
			internal unsafe delegate void GetQueryObjecti64v(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] Int64* @params);
			internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v;
			
			internal unsafe delegate void GetQueryObjectiv(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] Int32* @params);
			internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
			
			internal unsafe delegate void GetQueryObjectui64v(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] UInt64* @params);
			internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v;
			
			internal unsafe delegate void GetQueryObjectuiv(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] UInt32* @params);
			internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
			
			internal unsafe delegate void GetRenderbufferParameteriv(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferParameterName pname,[OutAttribute] Int32* @params);
			internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
			
			internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
			
			internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,[OutAttribute] Int32* @params);
			internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv;
			
			internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,[OutAttribute] UInt32* @params);
			internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv;
			
			internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
			
			internal delegate void GetSeparableFilter(Pencil.Gaming.Graphics.SeparableTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr row,[OutAttribute] IntPtr column,[OutAttribute] IntPtr span);
			internal static GetSeparableFilter glGetSeparableFilter;
			
			internal unsafe delegate void GetShaderInfoLog(UInt32 shader,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
			internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
			
			internal unsafe delegate void GetShaderiv(UInt32 shader,Pencil.Gaming.Graphics.ShaderParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetShaderiv glGetShaderiv;
			
			internal unsafe delegate void GetShaderPrecisionFormat(Pencil.Gaming.Graphics.ShaderType shadertype,Pencil.Gaming.Graphics.ShaderPrecisionType precisiontype,[OutAttribute] Int32* range,[OutAttribute] Int32* precision);
			internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
			
			internal unsafe delegate void GetShaderSource(UInt32 shader,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder source);
			internal unsafe static GetShaderSource glGetShaderSource;
			
			internal delegate IntPtr GetString(Pencil.Gaming.Graphics.StringName name);
			internal static GetString glGetString;
			
			internal delegate IntPtr GetStringi(Pencil.Gaming.Graphics.StringName name,UInt32 index);
			internal static GetStringi glGetStringi;
			
			internal delegate Int32 GetSubroutineIndex(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,String name);
			internal static GetSubroutineIndex glGetSubroutineIndex;
			
			internal delegate Int32 GetSubroutineUniformLocation(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,String name);
			internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;
			
			internal unsafe delegate void GetSynciv(IntPtr sync,Pencil.Gaming.Graphics.ArbSync pname,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* values);
			internal unsafe static GetSynciv glGetSynciv;
			
			internal unsafe delegate void GetTexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetTexEnvfv glGetTexEnvfv;
			
			internal unsafe delegate void GetTexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetTexEnviv glGetTexEnviv;
			
			internal unsafe delegate void GetTexGendv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Double* @params);
			internal unsafe static GetTexGendv glGetTexGendv;
			
			internal unsafe delegate void GetTexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetTexGenfv glGetTexGenfv;
			
			internal unsafe delegate void GetTexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetTexGeniv glGetTexGeniv;
			
			internal delegate void GetTexImage(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
			internal static GetTexImage glGetTexImage;
			
			internal unsafe delegate void GetTexLevelParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
			
			internal unsafe delegate void GetTexLevelParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
			
			internal unsafe delegate void GetTexParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetTexParameterfv glGetTexParameterfv;
			
			internal unsafe delegate void GetTexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetTexParameterIiv glGetTexParameterIiv;
			
			internal unsafe delegate void GetTexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] UInt32* @params);
			internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv;
			
			internal unsafe delegate void GetTexParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetTexParameteriv glGetTexParameteriv;
			
			internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type,[OutAttribute] StringBuilder name);
			internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
			
			internal delegate Int32 GetUniformBlockIndex(UInt32 program,String uniformBlockName);
			internal static GetUniformBlockIndex glGetUniformBlockIndex;
			
			internal unsafe delegate void GetUniformdv(UInt32 program,Int32 location,[OutAttribute] Double* @params);
			internal unsafe static GetUniformdv glGetUniformdv;
			
			internal unsafe delegate void GetUniformfv(UInt32 program,Int32 location,[OutAttribute] Single* @params);
			internal unsafe static GetUniformfv glGetUniformfv;
			
			internal unsafe delegate void GetUniformIndices(UInt32 program,Int32 uniformCount,String[] uniformNames,[OutAttribute] UInt32* uniformIndices);
			internal unsafe static GetUniformIndices glGetUniformIndices;
			
			internal unsafe delegate void GetUniformiv(UInt32 program,Int32 location,[OutAttribute] Int32* @params);
			internal unsafe static GetUniformiv glGetUniformiv;
			
			internal delegate Int32 GetUniformLocation(UInt32 program,String name);
			internal static GetUniformLocation glGetUniformLocation;
			
			internal unsafe delegate void GetUniformSubroutineuiv(Pencil.Gaming.Graphics.ShaderType shadertype,Int32 location,[OutAttribute] UInt32* @params);
			internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv;
			
			internal unsafe delegate void GetUniformuiv(UInt32 program,Int32 location,[OutAttribute] UInt32* @params);
			internal unsafe static GetUniformuiv glGetUniformuiv;
			
			internal unsafe delegate void GetVertexAttribdv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Double* @params);
			internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
			
			internal unsafe delegate void GetVertexAttribfv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Single* @params);
			internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
			
			internal unsafe delegate void GetVertexAttribIiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
			
			internal unsafe delegate void GetVertexAttribIuiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] UInt32* @params);
			internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
			
			internal unsafe delegate void GetVertexAttribiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Int32* @params);
			internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
			
			internal unsafe delegate void GetVertexAttribLdv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Double* @params);
			internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv;
			
			internal delegate void GetVertexAttribPointerv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribPointerParameter pname,[OutAttribute] IntPtr pointer);
			internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
			
			internal delegate void Hint(Pencil.Gaming.Graphics.HintTarget target,Pencil.Gaming.Graphics.HintMode mode);
			internal static Hint glHint;
			
			internal delegate void Histogram(Pencil.Gaming.Graphics.HistogramTarget target,Int32 width,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
			internal static Histogram glHistogram;
			
			internal delegate void Indexd(Double c);
			internal static Indexd glIndexd;
			
			internal unsafe delegate void Indexdv(Double* c);
			internal unsafe static Indexdv glIndexdv;
			
			internal delegate void Indexf(Single c);
			internal static Indexf glIndexf;
			
			internal unsafe delegate void Indexfv(Single* c);
			internal unsafe static Indexfv glIndexfv;
			
			internal delegate void Indexi(Int32 c);
			internal static Indexi glIndexi;
			
			internal unsafe delegate void Indexiv(Int32* c);
			internal unsafe static Indexiv glIndexiv;
			
			internal delegate void IndexMask(UInt32 mask);
			internal static IndexMask glIndexMask;
			
			internal delegate void IndexPointer(Pencil.Gaming.Graphics.IndexPointerType type,Int32 stride,IntPtr pointer);
			internal static IndexPointer glIndexPointer;
			
			internal delegate void Indexs(Int16 c);
			internal static Indexs glIndexs;
			
			internal unsafe delegate void Indexsv(Int16* c);
			internal unsafe static Indexsv glIndexsv;
			
			internal delegate void Indexub(Byte c);
			internal static Indexub glIndexub;
			
			internal unsafe delegate void Indexubv(Byte* c);
			internal unsafe static Indexubv glIndexubv;
			
			internal delegate void InitNames();
			internal static InitNames glInitNames;
			
			internal delegate void InterleavedArrays(Pencil.Gaming.Graphics.InterleavedArrayFormat format,Int32 stride,IntPtr pointer);
			internal static InterleavedArrays glInterleavedArrays;
			
			internal delegate bool IsBuffer(UInt32 buffer);
			internal static IsBuffer glIsBuffer;
			
			internal delegate bool IsEnabled(Pencil.Gaming.Graphics.EnableCap cap);
			internal static IsEnabled glIsEnabled;
			
			internal delegate bool IsEnabledi(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
			internal static IsEnabledi glIsEnabledi;
			
			internal delegate bool IsFramebuffer(UInt32 framebuffer);
			internal static IsFramebuffer glIsFramebuffer;
			
			internal delegate bool IsList(UInt32 list);
			internal static IsList glIsList;
			
			internal delegate bool IsProgram(UInt32 program);
			internal static IsProgram glIsProgram;
			
			internal delegate bool IsProgramPipeline(UInt32 pipeline);
			internal static IsProgramPipeline glIsProgramPipeline;
			
			internal delegate bool IsQuery(UInt32 id);
			internal static IsQuery glIsQuery;
			
			internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
			internal static IsRenderbuffer glIsRenderbuffer;
			
			internal delegate bool IsSampler(UInt32 sampler);
			internal static IsSampler glIsSampler;
			
			internal delegate bool IsShader(UInt32 shader);
			internal static IsShader glIsShader;
			
			internal delegate bool IsSync(IntPtr sync);
			internal static IsSync glIsSync;
			
			internal delegate bool IsTexture(UInt32 texture);
			internal static IsTexture glIsTexture;
			
			internal delegate bool IsTransformFeedback(UInt32 id);
			internal static IsTransformFeedback glIsTransformFeedback;
			
			internal delegate bool IsVertexArray(UInt32 array);
			internal static IsVertexArray glIsVertexArray;
			
			internal delegate void Lightf(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Single param);
			internal static Lightf glLightf;
			
			internal unsafe delegate void Lightfv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Single* @params);
			internal unsafe static Lightfv glLightfv;
			
			internal delegate void Lighti(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Int32 param);
			internal static Lighti glLighti;
			
			internal unsafe delegate void Lightiv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Int32* @params);
			internal unsafe static Lightiv glLightiv;
			
			internal delegate void LightModelf(Pencil.Gaming.Graphics.LightModelParameter pname,Single param);
			internal static LightModelf glLightModelf;
			
			internal unsafe delegate void LightModelfv(Pencil.Gaming.Graphics.LightModelParameter pname,Single* @params);
			internal unsafe static LightModelfv glLightModelfv;
			
			internal delegate void LightModeli(Pencil.Gaming.Graphics.LightModelParameter pname,Int32 param);
			internal static LightModeli glLightModeli;
			
			internal unsafe delegate void LightModeliv(Pencil.Gaming.Graphics.LightModelParameter pname,Int32* @params);
			internal unsafe static LightModeliv glLightModeliv;
			
			internal delegate void LineStipple(Int32 factor,UInt16 pattern);
			internal static LineStipple glLineStipple;
			
			internal delegate void LineWidth(Single width);
			internal static LineWidth glLineWidth;
			
			internal delegate void LinkProgram(UInt32 program);
			internal static LinkProgram glLinkProgram;
			
			internal delegate void ListBase(UInt32 @base);
			internal static ListBase glListBase;
			
			internal delegate void LoadIdentity();
			internal static LoadIdentity glLoadIdentity;
			
			internal unsafe delegate void LoadMatrixd(Double* m);
			internal unsafe static LoadMatrixd glLoadMatrixd;
			
			internal unsafe delegate void LoadMatrixf(Single* m);
			internal unsafe static LoadMatrixf glLoadMatrixf;
			
			internal delegate void LoadName(UInt32 name);
			internal static LoadName glLoadName;
			
			internal unsafe delegate void LoadTransposeMatrixd(Double* m);
			internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd;
			
			internal unsafe delegate void LoadTransposeMatrixf(Single* m);
			internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf;
			
			internal delegate void LogicOp(Pencil.Gaming.Graphics.LogicOp opcode);
			internal static LogicOp glLogicOp;
			
			internal unsafe delegate void Map1d(Pencil.Gaming.Graphics.MapTarget target,Double u1,Double u2,Int32 stride,Int32 order,Double* points);
			internal unsafe static Map1d glMap1d;
			
			internal unsafe delegate void Map1f(Pencil.Gaming.Graphics.MapTarget target,Single u1,Single u2,Int32 stride,Int32 order,Single* points);
			internal unsafe static Map1f glMap1f;
			
			internal unsafe delegate void Map2d(Pencil.Gaming.Graphics.MapTarget target,Double u1,Double u2,Int32 ustride,Int32 uorder,Double v1,Double v2,Int32 vstride,Int32 vorder,Double* points);
			internal unsafe static Map2d glMap2d;
			
			internal unsafe delegate void Map2f(Pencil.Gaming.Graphics.MapTarget target,Single u1,Single u2,Int32 ustride,Int32 uorder,Single v1,Single v2,Int32 vstride,Int32 vorder,Single* points);
			internal unsafe static Map2f glMap2f;
			
			internal unsafe delegate IntPtr MapBuffer(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferAccess access);
			internal unsafe static MapBuffer glMapBuffer;
			
			internal unsafe delegate IntPtr MapBufferRange(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr length,Pencil.Gaming.Graphics.BufferAccessMask access);
			internal unsafe static MapBufferRange glMapBufferRange;
			
			internal delegate void MapGrid1d(Int32 un,Double u1,Double u2);
			internal static MapGrid1d glMapGrid1d;
			
			internal delegate void MapGrid1f(Int32 un,Single u1,Single u2);
			internal static MapGrid1f glMapGrid1f;
			
			internal delegate void MapGrid2d(Int32 un,Double u1,Double u2,Int32 vn,Double v1,Double v2);
			internal static MapGrid2d glMapGrid2d;
			
			internal delegate void MapGrid2f(Int32 un,Single u1,Single u2,Int32 vn,Single v1,Single v2);
			internal static MapGrid2f glMapGrid2f;
			
			internal delegate void Materialf(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single param);
			internal static Materialf glMaterialf;
			
			internal unsafe delegate void Materialfv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single* @params);
			internal unsafe static Materialfv glMaterialfv;
			
			internal delegate void Materiali(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32 param);
			internal static Materiali glMateriali;
			
			internal unsafe delegate void Materialiv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32* @params);
			internal unsafe static Materialiv glMaterialiv;
			
			internal delegate void MatrixMode(Pencil.Gaming.Graphics.MatrixMode mode);
			internal static MatrixMode glMatrixMode;
			
			internal delegate void Minmax(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
			internal static Minmax glMinmax;
			
			internal delegate void MinSampleShading(Single value);
			internal static MinSampleShading glMinSampleShading;
			
			internal unsafe delegate void MultiDrawArrays(Pencil.Gaming.Graphics.BeginMode mode,Int32* first,Int32* count,Int32 primcount);
			internal unsafe static MultiDrawArrays glMultiDrawArrays;
			
			internal unsafe delegate void MultiDrawElements(Pencil.Gaming.Graphics.BeginMode mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
			internal unsafe static MultiDrawElements glMultiDrawElements;
			
			internal unsafe delegate void MultiDrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount,Int32* basevertex);
			internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
			
			internal delegate void MultiTexCoord1d(Pencil.Gaming.Graphics.TextureUnit target,Double s);
			internal static MultiTexCoord1d glMultiTexCoord1d;
			
			internal unsafe delegate void MultiTexCoord1dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
			internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv;
			
			internal delegate void MultiTexCoord1f(Pencil.Gaming.Graphics.TextureUnit target,Single s);
			internal static MultiTexCoord1f glMultiTexCoord1f;
			
			internal unsafe delegate void MultiTexCoord1fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
			internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv;
			
			internal delegate void MultiTexCoord1i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s);
			internal static MultiTexCoord1i glMultiTexCoord1i;
			
			internal unsafe delegate void MultiTexCoord1iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
			internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv;
			
			internal delegate void MultiTexCoord1s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s);
			internal static MultiTexCoord1s glMultiTexCoord1s;
			
			internal unsafe delegate void MultiTexCoord1sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
			internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv;
			
			internal delegate void MultiTexCoord2d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t);
			internal static MultiTexCoord2d glMultiTexCoord2d;
			
			internal unsafe delegate void MultiTexCoord2dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
			internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv;
			
			internal delegate void MultiTexCoord2f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t);
			internal static MultiTexCoord2f glMultiTexCoord2f;
			
			internal unsafe delegate void MultiTexCoord2fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
			internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv;
			
			internal delegate void MultiTexCoord2i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t);
			internal static MultiTexCoord2i glMultiTexCoord2i;
			
			internal unsafe delegate void MultiTexCoord2iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
			internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv;
			
			internal delegate void MultiTexCoord2s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t);
			internal static MultiTexCoord2s glMultiTexCoord2s;
			
			internal unsafe delegate void MultiTexCoord2sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
			internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv;
			
			internal delegate void MultiTexCoord3d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r);
			internal static MultiTexCoord3d glMultiTexCoord3d;
			
			internal unsafe delegate void MultiTexCoord3dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
			internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv;
			
			internal delegate void MultiTexCoord3f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r);
			internal static MultiTexCoord3f glMultiTexCoord3f;
			
			internal unsafe delegate void MultiTexCoord3fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
			internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv;
			
			internal delegate void MultiTexCoord3i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r);
			internal static MultiTexCoord3i glMultiTexCoord3i;
			
			internal unsafe delegate void MultiTexCoord3iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
			internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv;
			
			internal delegate void MultiTexCoord3s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r);
			internal static MultiTexCoord3s glMultiTexCoord3s;
			
			internal unsafe delegate void MultiTexCoord3sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
			internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv;
			
			internal delegate void MultiTexCoord4d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r,Double q);
			internal static MultiTexCoord4d glMultiTexCoord4d;
			
			internal unsafe delegate void MultiTexCoord4dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
			internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv;
			
			internal delegate void MultiTexCoord4f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r,Single q);
			internal static MultiTexCoord4f glMultiTexCoord4f;
			
			internal unsafe delegate void MultiTexCoord4fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
			internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv;
			
			internal delegate void MultiTexCoord4i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r,Int32 q);
			internal static MultiTexCoord4i glMultiTexCoord4i;
			
			internal unsafe delegate void MultiTexCoord4iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
			internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv;
			
			internal delegate void MultiTexCoord4s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r,Int16 q);
			internal static MultiTexCoord4s glMultiTexCoord4s;
			
			internal unsafe delegate void MultiTexCoord4sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
			internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv;
			
			internal delegate void MultiTexCoordP1ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static MultiTexCoordP1ui glMultiTexCoordP1ui;
			
			internal unsafe delegate void MultiTexCoordP1uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv;
			
			internal delegate void MultiTexCoordP2ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static MultiTexCoordP2ui glMultiTexCoordP2ui;
			
			internal unsafe delegate void MultiTexCoordP2uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv;
			
			internal delegate void MultiTexCoordP3ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static MultiTexCoordP3ui glMultiTexCoordP3ui;
			
			internal unsafe delegate void MultiTexCoordP3uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv;
			
			internal delegate void MultiTexCoordP4ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static MultiTexCoordP4ui glMultiTexCoordP4ui;
			
			internal unsafe delegate void MultiTexCoordP4uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv;
			
			internal unsafe delegate void MultMatrixd(Double* m);
			internal unsafe static MultMatrixd glMultMatrixd;
			
			internal unsafe delegate void MultMatrixf(Single* m);
			internal unsafe static MultMatrixf glMultMatrixf;
			
			internal unsafe delegate void MultTransposeMatrixd(Double* m);
			internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd;
			
			internal unsafe delegate void MultTransposeMatrixf(Single* m);
			internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf;
			
			internal delegate void NewList(UInt32 list,Pencil.Gaming.Graphics.ListMode mode);
			internal static NewList glNewList;
			
			internal delegate void Normal3b(SByte nx,SByte ny,SByte nz);
			internal static Normal3b glNormal3b;
			
			internal unsafe delegate void Normal3bv(SByte* v);
			internal unsafe static Normal3bv glNormal3bv;
			
			internal delegate void Normal3d(Double nx,Double ny,Double nz);
			internal static Normal3d glNormal3d;
			
			internal unsafe delegate void Normal3dv(Double* v);
			internal unsafe static Normal3dv glNormal3dv;
			
			internal delegate void Normal3f(Single nx,Single ny,Single nz);
			internal static Normal3f glNormal3f;
			
			internal unsafe delegate void Normal3fv(Single* v);
			internal unsafe static Normal3fv glNormal3fv;
			
			internal delegate void Normal3i(Int32 nx,Int32 ny,Int32 nz);
			internal static Normal3i glNormal3i;
			
			internal unsafe delegate void Normal3iv(Int32* v);
			internal unsafe static Normal3iv glNormal3iv;
			
			internal delegate void Normal3s(Int16 nx,Int16 ny,Int16 nz);
			internal static Normal3s glNormal3s;
			
			internal unsafe delegate void Normal3sv(Int16* v);
			internal unsafe static Normal3sv glNormal3sv;
			
			internal delegate void NormalP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static NormalP3ui glNormalP3ui;
			
			internal unsafe delegate void NormalP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static NormalP3uiv glNormalP3uiv;
			
			internal delegate void NormalPointer(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,IntPtr pointer);
			internal static NormalPointer glNormalPointer;
			
			internal delegate void Ortho(Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
			internal static Ortho glOrtho;
			
			internal delegate void PassThrough(Single token);
			internal static PassThrough glPassThrough;
			
			internal unsafe delegate void PatchParameterfv(Pencil.Gaming.Graphics.PatchParameterFloat pname,Single* values);
			internal unsafe static PatchParameterfv glPatchParameterfv;
			
			internal delegate void PatchParameteri(Pencil.Gaming.Graphics.PatchParameterInt pname,Int32 value);
			internal static PatchParameteri glPatchParameteri;
			
			internal delegate void PauseTransformFeedback();
			internal static PauseTransformFeedback glPauseTransformFeedback;
			
			internal unsafe delegate void PixelMapfv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,Single* values);
			internal unsafe static PixelMapfv glPixelMapfv;
			
			internal unsafe delegate void PixelMapuiv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,UInt32* values);
			internal unsafe static PixelMapuiv glPixelMapuiv;
			
			internal unsafe delegate void PixelMapusv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,UInt16* values);
			internal unsafe static PixelMapusv glPixelMapusv;
			
			internal delegate void PixelStoref(Pencil.Gaming.Graphics.PixelStoreParameter pname,Single param);
			internal static PixelStoref glPixelStoref;
			
			internal delegate void PixelStorei(Pencil.Gaming.Graphics.PixelStoreParameter pname,Int32 param);
			internal static PixelStorei glPixelStorei;
			
			internal delegate void PixelTransferf(Pencil.Gaming.Graphics.PixelTransferParameter pname,Single param);
			internal static PixelTransferf glPixelTransferf;
			
			internal delegate void PixelTransferi(Pencil.Gaming.Graphics.PixelTransferParameter pname,Int32 param);
			internal static PixelTransferi glPixelTransferi;
			
			internal delegate void PixelZoom(Single xfactor,Single yfactor);
			internal static PixelZoom glPixelZoom;
			
			internal delegate void PointParameterf(Pencil.Gaming.Graphics.PointParameterName pname,Single param);
			internal static PointParameterf glPointParameterf;
			
			internal unsafe delegate void PointParameterfv(Pencil.Gaming.Graphics.PointParameterName pname,Single* @params);
			internal unsafe static PointParameterfv glPointParameterfv;
			
			internal delegate void PointParameteri(Pencil.Gaming.Graphics.PointParameterName pname,Int32 param);
			internal static PointParameteri glPointParameteri;
			
			internal unsafe delegate void PointParameteriv(Pencil.Gaming.Graphics.PointParameterName pname,Int32* @params);
			internal unsafe static PointParameteriv glPointParameteriv;
			
			internal delegate void PointSize(Single size);
			internal static PointSize glPointSize;
			
			internal delegate void PolygonMode(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.PolygonMode mode);
			internal static PolygonMode glPolygonMode;
			
			internal delegate void PolygonOffset(Single factor,Single units);
			internal static PolygonOffset glPolygonOffset;
			
			internal unsafe delegate void PolygonStipple(Byte* mask);
			internal unsafe static PolygonStipple glPolygonStipple;
			
			internal delegate void PopAttrib();
			internal static PopAttrib glPopAttrib;
			
			internal delegate void PopClientAttrib();
			internal static PopClientAttrib glPopClientAttrib;
			
			internal delegate void PopMatrix();
			internal static PopMatrix glPopMatrix;
			
			internal delegate void PopName();
			internal static PopName glPopName;
			
			internal delegate void PrimitiveRestartIndex(UInt32 index);
			internal static PrimitiveRestartIndex glPrimitiveRestartIndex;
			
			internal unsafe delegate void PrioritizeTextures(Int32 n,UInt32* textures,Single* priorities);
			internal unsafe static PrioritizeTextures glPrioritizeTextures;
			
			internal delegate void ProgramBinary(UInt32 program,Pencil.Gaming.Graphics.BinaryFormat binaryFormat,IntPtr binary,Int32 length);
			internal static ProgramBinary glProgramBinary;
			
			internal delegate void ProgramParameteri(UInt32 program,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,Int32 value);
			internal static ProgramParameteri glProgramParameteri;
			
			internal delegate void ProgramUniform1d(UInt32 program,Int32 location,Double v0);
			internal static ProgramUniform1d glProgramUniform1d;
			
			internal unsafe delegate void ProgramUniform1dv(UInt32 program,Int32 location,Int32 count,Double* value);
			internal unsafe static ProgramUniform1dv glProgramUniform1dv;
			
			internal delegate void ProgramUniform1f(UInt32 program,Int32 location,Single v0);
			internal static ProgramUniform1f glProgramUniform1f;
			
			internal unsafe delegate void ProgramUniform1fv(UInt32 program,Int32 location,Int32 count,Single* value);
			internal unsafe static ProgramUniform1fv glProgramUniform1fv;
			
			internal delegate void ProgramUniform1i(UInt32 program,Int32 location,Int32 v0);
			internal static ProgramUniform1i glProgramUniform1i;
			
			internal unsafe delegate void ProgramUniform1iv(UInt32 program,Int32 location,Int32 count,Int32* value);
			internal unsafe static ProgramUniform1iv glProgramUniform1iv;
			
			internal delegate void ProgramUniform1ui(UInt32 program,Int32 location,UInt32 v0);
			internal static ProgramUniform1ui glProgramUniform1ui;
			
			internal unsafe delegate void ProgramUniform1uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
			internal unsafe static ProgramUniform1uiv glProgramUniform1uiv;
			
			internal delegate void ProgramUniform2d(UInt32 program,Int32 location,Double v0,Double v1);
			internal static ProgramUniform2d glProgramUniform2d;
			
			internal unsafe delegate void ProgramUniform2dv(UInt32 program,Int32 location,Int32 count,Double* value);
			internal unsafe static ProgramUniform2dv glProgramUniform2dv;
			
			internal delegate void ProgramUniform2f(UInt32 program,Int32 location,Single v0,Single v1);
			internal static ProgramUniform2f glProgramUniform2f;
			
			internal unsafe delegate void ProgramUniform2fv(UInt32 program,Int32 location,Int32 count,Single* value);
			internal unsafe static ProgramUniform2fv glProgramUniform2fv;
			
			internal delegate void ProgramUniform2i(UInt32 program,Int32 location,Int32 v0,Int32 v1);
			internal static ProgramUniform2i glProgramUniform2i;
			
			internal unsafe delegate void ProgramUniform2iv(UInt32 program,Int32 location,Int32 count,Int32* value);
			internal unsafe static ProgramUniform2iv glProgramUniform2iv;
			
			internal delegate void ProgramUniform2ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1);
			internal static ProgramUniform2ui glProgramUniform2ui;
			
			internal unsafe delegate void ProgramUniform2uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
			internal unsafe static ProgramUniform2uiv glProgramUniform2uiv;
			
			internal delegate void ProgramUniform3d(UInt32 program,Int32 location,Double v0,Double v1,Double v2);
			internal static ProgramUniform3d glProgramUniform3d;
			
			internal unsafe delegate void ProgramUniform3dv(UInt32 program,Int32 location,Int32 count,Double* value);
			internal unsafe static ProgramUniform3dv glProgramUniform3dv;
			
			internal delegate void ProgramUniform3f(UInt32 program,Int32 location,Single v0,Single v1,Single v2);
			internal static ProgramUniform3f glProgramUniform3f;
			
			internal unsafe delegate void ProgramUniform3fv(UInt32 program,Int32 location,Int32 count,Single* value);
			internal unsafe static ProgramUniform3fv glProgramUniform3fv;
			
			internal delegate void ProgramUniform3i(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2);
			internal static ProgramUniform3i glProgramUniform3i;
			
			internal unsafe delegate void ProgramUniform3iv(UInt32 program,Int32 location,Int32 count,Int32* value);
			internal unsafe static ProgramUniform3iv glProgramUniform3iv;
			
			internal delegate void ProgramUniform3ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
			internal static ProgramUniform3ui glProgramUniform3ui;
			
			internal unsafe delegate void ProgramUniform3uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
			internal unsafe static ProgramUniform3uiv glProgramUniform3uiv;
			
			internal delegate void ProgramUniform4d(UInt32 program,Int32 location,Double v0,Double v1,Double v2,Double v3);
			internal static ProgramUniform4d glProgramUniform4d;
			
			internal unsafe delegate void ProgramUniform4dv(UInt32 program,Int32 location,Int32 count,Double* value);
			internal unsafe static ProgramUniform4dv glProgramUniform4dv;
			
			internal delegate void ProgramUniform4f(UInt32 program,Int32 location,Single v0,Single v1,Single v2,Single v3);
			internal static ProgramUniform4f glProgramUniform4f;
			
			internal unsafe delegate void ProgramUniform4fv(UInt32 program,Int32 location,Int32 count,Single* value);
			internal unsafe static ProgramUniform4fv glProgramUniform4fv;
			
			internal delegate void ProgramUniform4i(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
			internal static ProgramUniform4i glProgramUniform4i;
			
			internal unsafe delegate void ProgramUniform4iv(UInt32 program,Int32 location,Int32 count,Int32* value);
			internal unsafe static ProgramUniform4iv glProgramUniform4iv;
			
			internal delegate void ProgramUniform4ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
			internal static ProgramUniform4ui glProgramUniform4ui;
			
			internal unsafe delegate void ProgramUniform4uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
			internal unsafe static ProgramUniform4uiv glProgramUniform4uiv;
			
			internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv;
			
			internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;
			
			internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
			
			internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
			
			internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
			
			internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
			
			internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv;
			
			internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;
			
			internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
			
			internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
			
			internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
			
			internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
			
			internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv;
			
			internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;
			
			internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
			
			internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
			
			internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;
			
			internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;
			
			internal delegate void ProvokingVertex(Pencil.Gaming.Graphics.ProvokingVertexMode mode);
			internal static ProvokingVertex glProvokingVertex;
			
			internal delegate void PushAttrib(Pencil.Gaming.Graphics.AttribMask mask);
			internal static PushAttrib glPushAttrib;
			
			internal delegate void PushClientAttrib(Pencil.Gaming.Graphics.ClientAttribMask mask);
			internal static PushClientAttrib glPushClientAttrib;
			
			internal delegate void PushMatrix();
			internal static PushMatrix glPushMatrix;
			
			internal delegate void PushName(UInt32 name);
			internal static PushName glPushName;
			
			internal delegate void QueryCounter(UInt32 id,Pencil.Gaming.Graphics.QueryCounterTarget target);
			internal static QueryCounter glQueryCounter;
			
			internal delegate void RasterPos2d(Double x,Double y);
			internal static RasterPos2d glRasterPos2d;
			
			internal unsafe delegate void RasterPos2dv(Double* v);
			internal unsafe static RasterPos2dv glRasterPos2dv;
			
			internal delegate void RasterPos2f(Single x,Single y);
			internal static RasterPos2f glRasterPos2f;
			
			internal unsafe delegate void RasterPos2fv(Single* v);
			internal unsafe static RasterPos2fv glRasterPos2fv;
			
			internal delegate void RasterPos2i(Int32 x,Int32 y);
			internal static RasterPos2i glRasterPos2i;
			
			internal unsafe delegate void RasterPos2iv(Int32* v);
			internal unsafe static RasterPos2iv glRasterPos2iv;
			
			internal delegate void RasterPos2s(Int16 x,Int16 y);
			internal static RasterPos2s glRasterPos2s;
			
			internal unsafe delegate void RasterPos2sv(Int16* v);
			internal unsafe static RasterPos2sv glRasterPos2sv;
			
			internal delegate void RasterPos3d(Double x,Double y,Double z);
			internal static RasterPos3d glRasterPos3d;
			
			internal unsafe delegate void RasterPos3dv(Double* v);
			internal unsafe static RasterPos3dv glRasterPos3dv;
			
			internal delegate void RasterPos3f(Single x,Single y,Single z);
			internal static RasterPos3f glRasterPos3f;
			
			internal unsafe delegate void RasterPos3fv(Single* v);
			internal unsafe static RasterPos3fv glRasterPos3fv;
			
			internal delegate void RasterPos3i(Int32 x,Int32 y,Int32 z);
			internal static RasterPos3i glRasterPos3i;
			
			internal unsafe delegate void RasterPos3iv(Int32* v);
			internal unsafe static RasterPos3iv glRasterPos3iv;
			
			internal delegate void RasterPos3s(Int16 x,Int16 y,Int16 z);
			internal static RasterPos3s glRasterPos3s;
			
			internal unsafe delegate void RasterPos3sv(Int16* v);
			internal unsafe static RasterPos3sv glRasterPos3sv;
			
			internal delegate void RasterPos4d(Double x,Double y,Double z,Double w);
			internal static RasterPos4d glRasterPos4d;
			
			internal unsafe delegate void RasterPos4dv(Double* v);
			internal unsafe static RasterPos4dv glRasterPos4dv;
			
			internal delegate void RasterPos4f(Single x,Single y,Single z,Single w);
			internal static RasterPos4f glRasterPos4f;
			
			internal unsafe delegate void RasterPos4fv(Single* v);
			internal unsafe static RasterPos4fv glRasterPos4fv;
			
			internal delegate void RasterPos4i(Int32 x,Int32 y,Int32 z,Int32 w);
			internal static RasterPos4i glRasterPos4i;
			
			internal unsafe delegate void RasterPos4iv(Int32* v);
			internal unsafe static RasterPos4iv glRasterPos4iv;
			
			internal delegate void RasterPos4s(Int16 x,Int16 y,Int16 z,Int16 w);
			internal static RasterPos4s glRasterPos4s;
			
			internal unsafe delegate void RasterPos4sv(Int16* v);
			internal unsafe static RasterPos4sv glRasterPos4sv;
			
			internal delegate void ReadBuffer(Pencil.Gaming.Graphics.ReadBufferMode mode);
			internal static ReadBuffer glReadBuffer;
			
			internal delegate void ReadPixels(Int32 x,Int32 y,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
			internal static ReadPixels glReadPixels;
			
			internal delegate void Rectd(Double x1,Double y1,Double x2,Double y2);
			internal static Rectd glRectd;
			
			internal unsafe delegate void Rectdv(Double* v1,Double* v2);
			internal unsafe static Rectdv glRectdv;
			
			internal delegate void Rectf(Single x1,Single y1,Single x2,Single y2);
			internal static Rectf glRectf;
			
			internal unsafe delegate void Rectfv(Single* v1,Single* v2);
			internal unsafe static Rectfv glRectfv;
			
			internal delegate void Recti(Int32 x1,Int32 y1,Int32 x2,Int32 y2);
			internal static Recti glRecti;
			
			internal unsafe delegate void Rectiv(Int32* v1,Int32* v2);
			internal unsafe static Rectiv glRectiv;
			
			internal delegate void Rects(Int16 x1,Int16 y1,Int16 x2,Int16 y2);
			internal static Rects glRects;
			
			internal unsafe delegate void Rectsv(Int16* v1,Int16* v2);
			internal unsafe static Rectsv glRectsv;
			
			internal delegate void ReleaseShaderCompiler();
			internal static ReleaseShaderCompiler glReleaseShaderCompiler;
			
			internal delegate void RenderbufferStorage(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferStorage internalformat,Int32 width,Int32 height);
			internal static RenderbufferStorage glRenderbufferStorage;
			
			internal delegate void RenderbufferStorageMultisample(Pencil.Gaming.Graphics.RenderbufferTarget target,Int32 samples,Pencil.Gaming.Graphics.RenderbufferStorage internalformat,Int32 width,Int32 height);
			internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
			
			internal delegate Int32 RenderMode(Pencil.Gaming.Graphics.RenderingMode mode);
			internal static RenderMode glRenderMode;
			
			internal delegate void ResetHistogram(Pencil.Gaming.Graphics.HistogramTarget target);
			internal static ResetHistogram glResetHistogram;
			
			internal delegate void ResetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target);
			internal static ResetMinmax glResetMinmax;
			
			internal delegate void ResumeTransformFeedback();
			internal static ResumeTransformFeedback glResumeTransformFeedback;
			
			internal delegate void Rotated(Double angle,Double x,Double y,Double z);
			internal static Rotated glRotated;
			
			internal delegate void Rotatef(Single angle,Single x,Single y,Single z);
			internal static Rotatef glRotatef;
			
			internal delegate void SampleCoverage(Single value,bool invert);
			internal static SampleCoverage glSampleCoverage;
			
			internal delegate void SampleMaski(UInt32 index,UInt32 mask);
			internal static SampleMaski glSampleMaski;
			
			internal delegate void SamplerParameterf(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Single param);
			internal static SamplerParameterf glSamplerParameterf;
			
			internal unsafe delegate void SamplerParameterfv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Single* param);
			internal unsafe static SamplerParameterfv glSamplerParameterfv;
			
			internal delegate void SamplerParameteri(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Int32 param);
			internal static SamplerParameteri glSamplerParameteri;
			
			internal unsafe delegate void SamplerParameterIiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,Int32* param);
			internal unsafe static SamplerParameterIiv glSamplerParameterIiv;
			
			internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,UInt32* param);
			internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv;
			
			internal unsafe delegate void SamplerParameteriv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Int32* param);
			internal unsafe static SamplerParameteriv glSamplerParameteriv;
			
			internal delegate void Scaled(Double x,Double y,Double z);
			internal static Scaled glScaled;
			
			internal delegate void Scalef(Single x,Single y,Single z);
			internal static Scalef glScalef;
			
			internal delegate void Scissor(Int32 x,Int32 y,Int32 width,Int32 height);
			internal static Scissor glScissor;
			
			internal unsafe delegate void ScissorArrayv(UInt32 first,Int32 count,Int32* v);
			internal unsafe static ScissorArrayv glScissorArrayv;
			
			internal delegate void ScissorIndexed(UInt32 index,Int32 left,Int32 bottom,Int32 width,Int32 height);
			internal static ScissorIndexed glScissorIndexed;
			
			internal unsafe delegate void ScissorIndexedv(UInt32 index,Int32* v);
			internal unsafe static ScissorIndexedv glScissorIndexedv;
			
			internal delegate void SecondaryColor3b(SByte red,SByte green,SByte blue);
			internal static SecondaryColor3b glSecondaryColor3b;
			
			internal unsafe delegate void SecondaryColor3bv(SByte* v);
			internal unsafe static SecondaryColor3bv glSecondaryColor3bv;
			
			internal delegate void SecondaryColor3d(Double red,Double green,Double blue);
			internal static SecondaryColor3d glSecondaryColor3d;
			
			internal unsafe delegate void SecondaryColor3dv(Double* v);
			internal unsafe static SecondaryColor3dv glSecondaryColor3dv;
			
			internal delegate void SecondaryColor3f(Single red,Single green,Single blue);
			internal static SecondaryColor3f glSecondaryColor3f;
			
			internal unsafe delegate void SecondaryColor3fv(Single* v);
			internal unsafe static SecondaryColor3fv glSecondaryColor3fv;
			
			internal delegate void SecondaryColor3i(Int32 red,Int32 green,Int32 blue);
			internal static SecondaryColor3i glSecondaryColor3i;
			
			internal unsafe delegate void SecondaryColor3iv(Int32* v);
			internal unsafe static SecondaryColor3iv glSecondaryColor3iv;
			
			internal delegate void SecondaryColor3s(Int16 red,Int16 green,Int16 blue);
			internal static SecondaryColor3s glSecondaryColor3s;
			
			internal unsafe delegate void SecondaryColor3sv(Int16* v);
			internal unsafe static SecondaryColor3sv glSecondaryColor3sv;
			
			internal delegate void SecondaryColor3ub(Byte red,Byte green,Byte blue);
			internal static SecondaryColor3ub glSecondaryColor3ub;
			
			internal unsafe delegate void SecondaryColor3ubv(Byte* v);
			internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv;
			
			internal delegate void SecondaryColor3ui(UInt32 red,UInt32 green,UInt32 blue);
			internal static SecondaryColor3ui glSecondaryColor3ui;
			
			internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
			internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv;
			
			internal delegate void SecondaryColor3us(UInt16 red,UInt16 green,UInt16 blue);
			internal static SecondaryColor3us glSecondaryColor3us;
			
			internal unsafe delegate void SecondaryColor3usv(UInt16* v);
			internal unsafe static SecondaryColor3usv glSecondaryColor3usv;
			
			internal delegate void SecondaryColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
			internal static SecondaryColorP3ui glSecondaryColorP3ui;
			
			internal unsafe delegate void SecondaryColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
			internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv;
			
			internal delegate void SecondaryColorPointer(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer);
			internal static SecondaryColorPointer glSecondaryColorPointer;
			
			internal unsafe delegate void SelectBuffer(Int32 size,[OutAttribute] UInt32* buffer);
			internal unsafe static SelectBuffer glSelectBuffer;
			
			internal delegate void SeparableFilter2D(Pencil.Gaming.Graphics.SeparableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr row,IntPtr column);
			internal static SeparableFilter2D glSeparableFilter2D;
			
			internal delegate void ShadeModel(Pencil.Gaming.Graphics.ShadingModel mode);
			internal static ShadeModel glShadeModel;
			
			internal unsafe delegate void ShaderBinary(Int32 count,UInt32* shaders,Pencil.Gaming.Graphics.BinaryFormat binaryformat,IntPtr binary,Int32 length);
			internal unsafe static ShaderBinary glShaderBinary;
			
			internal unsafe delegate void ShaderSource(UInt32 shader,Int32 count,String[] @string,Int32* length);
			internal unsafe static ShaderSource glShaderSource;
			
			internal delegate void StencilFunc(Pencil.Gaming.Graphics.StencilFunction func,Int32 @ref,UInt32 mask);
			internal static StencilFunc glStencilFunc;
			
			internal delegate void StencilFuncSeparate(Pencil.Gaming.Graphics.StencilFace face,Pencil.Gaming.Graphics.StencilFunction func,Int32 @ref,UInt32 mask);
			internal static StencilFuncSeparate glStencilFuncSeparate;
			
			internal delegate void StencilMask(UInt32 mask);
			internal static StencilMask glStencilMask;
			
			internal delegate void StencilMaskSeparate(Pencil.Gaming.Graphics.StencilFace face,UInt32 mask);
			internal static StencilMaskSeparate glStencilMaskSeparate;
			
			internal delegate void StencilOp(Pencil.Gaming.Graphics.StencilOp fail,Pencil.Gaming.Graphics.StencilOp zfail,Pencil.Gaming.Graphics.StencilOp zpass);
			internal static StencilOp glStencilOp;
			
			internal delegate void StencilOpSeparate(Pencil.Gaming.Graphics.StencilFace face,Pencil.Gaming.Graphics.StencilOp sfail,Pencil.Gaming.Graphics.StencilOp dpfail,Pencil.Gaming.Graphics.StencilOp dppass);
			internal static StencilOpSeparate glStencilOpSeparate;
			
			internal delegate void StringMarkerGREMEDY(Int32 len,IntPtr @string);
			internal static StringMarkerGREMEDY glStringMarkerGREMEDY;
			
			internal delegate void TbufferMask3DFX(UInt32 mask);
			internal static TbufferMask3DFX glTbufferMask3DFX;
			
			internal delegate void TexBuffer(Pencil.Gaming.Graphics.TextureBufferTarget target,Pencil.Gaming.Graphics.SizedInternalFormat internalformat,UInt32 buffer);
			internal static TexBuffer glTexBuffer;
			
			internal delegate void TexCoord1d(Double s);
			internal static TexCoord1d glTexCoord1d;
			
			internal unsafe delegate void TexCoord1dv(Double* v);
			internal unsafe static TexCoord1dv glTexCoord1dv;
			
			internal delegate void TexCoord1f(Single s);
			internal static TexCoord1f glTexCoord1f;
			
			internal unsafe delegate void TexCoord1fv(Single* v);
			internal unsafe static TexCoord1fv glTexCoord1fv;
			
			internal delegate void TexCoord1i(Int32 s);
			internal static TexCoord1i glTexCoord1i;
			
			internal unsafe delegate void TexCoord1iv(Int32* v);
			internal unsafe static TexCoord1iv glTexCoord1iv;
			
			internal delegate void TexCoord1s(Int16 s);
			internal static TexCoord1s glTexCoord1s;
			
			internal unsafe delegate void TexCoord1sv(Int16* v);
			internal unsafe static TexCoord1sv glTexCoord1sv;
			
			internal delegate void TexCoord2d(Double s,Double t);
			internal static TexCoord2d glTexCoord2d;
			
			internal unsafe delegate void TexCoord2dv(Double* v);
			internal unsafe static TexCoord2dv glTexCoord2dv;
			
			internal delegate void TexCoord2f(Single s,Single t);
			internal static TexCoord2f glTexCoord2f;
			
			internal unsafe delegate void TexCoord2fv(Single* v);
			internal unsafe static TexCoord2fv glTexCoord2fv;
			
			internal delegate void TexCoord2i(Int32 s,Int32 t);
			internal static TexCoord2i glTexCoord2i;
			
			internal unsafe delegate void TexCoord2iv(Int32* v);
			internal unsafe static TexCoord2iv glTexCoord2iv;
			
			internal delegate void TexCoord2s(Int16 s,Int16 t);
			internal static TexCoord2s glTexCoord2s;
			
			internal unsafe delegate void TexCoord2sv(Int16* v);
			internal unsafe static TexCoord2sv glTexCoord2sv;
			
			internal delegate void TexCoord3d(Double s,Double t,Double r);
			internal static TexCoord3d glTexCoord3d;
			
			internal unsafe delegate void TexCoord3dv(Double* v);
			internal unsafe static TexCoord3dv glTexCoord3dv;
			
			internal delegate void TexCoord3f(Single s,Single t,Single r);
			internal static TexCoord3f glTexCoord3f;
			
			internal unsafe delegate void TexCoord3fv(Single* v);
			internal unsafe static TexCoord3fv glTexCoord3fv;
			
			internal delegate void TexCoord3i(Int32 s,Int32 t,Int32 r);
			internal static TexCoord3i glTexCoord3i;
			
			internal unsafe delegate void TexCoord3iv(Int32* v);
			internal unsafe static TexCoord3iv glTexCoord3iv;
			
			internal delegate void TexCoord3s(Int16 s,Int16 t,Int16 r);
			internal static TexCoord3s glTexCoord3s;
			
			internal unsafe delegate void TexCoord3sv(Int16* v);
			internal unsafe static TexCoord3sv glTexCoord3sv;
			
			internal delegate void TexCoord4d(Double s,Double t,Double r,Double q);
			internal static TexCoord4d glTexCoord4d;
			
			internal unsafe delegate void TexCoord4dv(Double* v);
			internal unsafe static TexCoord4dv glTexCoord4dv;
			
			internal delegate void TexCoord4f(Single s,Single t,Single r,Single q);
			internal static TexCoord4f glTexCoord4f;
			
			internal unsafe delegate void TexCoord4fv(Single* v);
			internal unsafe static TexCoord4fv glTexCoord4fv;
			
			internal delegate void TexCoord4i(Int32 s,Int32 t,Int32 r,Int32 q);
			internal static TexCoord4i glTexCoord4i;
			
			internal unsafe delegate void TexCoord4iv(Int32* v);
			internal unsafe static TexCoord4iv glTexCoord4iv;
			
			internal delegate void TexCoord4s(Int16 s,Int16 t,Int16 r,Int16 q);
			internal static TexCoord4s glTexCoord4s;
			
			internal unsafe delegate void TexCoord4sv(Int16* v);
			internal unsafe static TexCoord4sv glTexCoord4sv;
			
			internal delegate void TexCoordP1ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static TexCoordP1ui glTexCoordP1ui;
			
			internal unsafe delegate void TexCoordP1uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static TexCoordP1uiv glTexCoordP1uiv;
			
			internal delegate void TexCoordP2ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static TexCoordP2ui glTexCoordP2ui;
			
			internal unsafe delegate void TexCoordP2uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static TexCoordP2uiv glTexCoordP2uiv;
			
			internal delegate void TexCoordP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static TexCoordP3ui glTexCoordP3ui;
			
			internal unsafe delegate void TexCoordP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static TexCoordP3uiv glTexCoordP3uiv;
			
			internal delegate void TexCoordP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
			internal static TexCoordP4ui glTexCoordP4ui;
			
			internal unsafe delegate void TexCoordP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
			internal unsafe static TexCoordP4uiv glTexCoordP4uiv;
			
			internal delegate void TexCoordPointer(Int32 size,Pencil.Gaming.Graphics.TexCoordPointerType type,Int32 stride,IntPtr pointer);
			internal static TexCoordPointer glTexCoordPointer;
			
			
			internal delegate void TexEnvf(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single param);
			internal static TexEnvf glTexEnvf;
			
			internal unsafe delegate void TexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single* @params);
			internal unsafe static TexEnvfv glTexEnvfv;
			
			internal delegate void TexEnvi(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32 param);
			internal static TexEnvi glTexEnvi;
			
			internal unsafe delegate void TexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32* @params);
			internal unsafe static TexEnviv glTexEnviv;
			
			internal delegate void TexGend(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double param);
			internal static TexGend glTexGend;
			
			internal unsafe delegate void TexGendv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double* @params);
			internal unsafe static TexGendv glTexGendv;
			
			internal delegate void TexGenf(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single param);
			internal static TexGenf glTexGenf;
			
			internal unsafe delegate void TexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single* @params);
			internal unsafe static TexGenfv glTexGenfv;
			
			internal delegate void TexGeni(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32 param);
			internal static TexGeni glTexGeni;
			
			internal unsafe delegate void TexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32* @params);
			internal unsafe static TexGeniv glTexGeniv;
			
			internal delegate void TexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexImage1D glTexImage1D;
			
			internal delegate void TexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexImage2D glTexImage2D;
			
			internal delegate void TexImage2DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target,Int32 samples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,bool fixedsamplelocations);
			internal static TexImage2DMultisample glTexImage2DMultisample;
			
			internal delegate void TexImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexImage3D glTexImage3D;
			
			internal delegate void TexImage3DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target,Int32 samples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,bool fixedsamplelocations);
			internal static TexImage3DMultisample glTexImage3DMultisample;
			
			internal delegate void TexParameterf(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single param);
			internal static TexParameterf glTexParameterf;
			
			internal unsafe delegate void TexParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single* @params);
			internal unsafe static TexParameterfv glTexParameterfv;
			
			internal delegate void TexParameteri(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32 param);
			internal static TexParameteri glTexParameteri;
			
			internal unsafe delegate void TexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
			internal unsafe static TexParameterIiv glTexParameterIiv;
			
			internal unsafe delegate void TexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,UInt32* @params);
			internal unsafe static TexParameterIuiv glTexParameterIuiv;
			
			internal unsafe delegate void TexParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
			internal unsafe static TexParameteriv glTexParameteriv;
			
			internal delegate void TexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexSubImage1D glTexSubImage1D;
			
			internal delegate void TexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexSubImage2D glTexSubImage2D;
			
			internal delegate void TexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
			internal static TexSubImage3D glTexSubImage3D;
			
			internal delegate void TransformFeedbackVaryings(UInt32 program,Int32 count,String[] varyings,Pencil.Gaming.Graphics.TransformFeedbackMode bufferMode);
			internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
			
			internal delegate void Translated(Double x,Double y,Double z);
			internal static Translated glTranslated;
			
			internal delegate void Translatef(Single x,Single y,Single z);
			internal static Translatef glTranslatef;
			
			internal delegate void Uniform1d(Int32 location,Double x);
			internal static Uniform1d glUniform1d;
			
			internal unsafe delegate void Uniform1dv(Int32 location,Int32 count,Double* value);
			internal unsafe static Uniform1dv glUniform1dv;
			
			internal delegate void Uniform1f(Int32 location,Single v0);
			internal static Uniform1f glUniform1f;
			
			internal unsafe delegate void Uniform1fv(Int32 location,Int32 count,Single* value);
			internal unsafe static Uniform1fv glUniform1fv;
			
			internal delegate void Uniform1i(Int32 location,Int32 v0);
			internal static Uniform1i glUniform1i;
			
			internal unsafe delegate void Uniform1iv(Int32 location,Int32 count,Int32* value);
			internal unsafe static Uniform1iv glUniform1iv;
			
			internal delegate void Uniform1ui(Int32 location,UInt32 v0);
			internal static Uniform1ui glUniform1ui;
			
			internal unsafe delegate void Uniform1uiv(Int32 location,Int32 count,UInt32* value);
			internal unsafe static Uniform1uiv glUniform1uiv;
			
			internal delegate void Uniform2d(Int32 location,Double x,Double y);
			internal static Uniform2d glUniform2d;
			
			internal unsafe delegate void Uniform2dv(Int32 location,Int32 count,Double* value);
			internal unsafe static Uniform2dv glUniform2dv;
			
			internal delegate void Uniform2f(Int32 location,Single v0,Single v1);
			internal static Uniform2f glUniform2f;
			
			internal unsafe delegate void Uniform2fv(Int32 location,Int32 count,Single* value);
			internal unsafe static Uniform2fv glUniform2fv;
			
			internal delegate void Uniform2i(Int32 location,Int32 v0,Int32 v1);
			internal static Uniform2i glUniform2i;
			
			internal unsafe delegate void Uniform2iv(Int32 location,Int32 count,Int32* value);
			internal unsafe static Uniform2iv glUniform2iv;
			
			internal delegate void Uniform2ui(Int32 location,UInt32 v0,UInt32 v1);
			internal static Uniform2ui glUniform2ui;
			
			internal unsafe delegate void Uniform2uiv(Int32 location,Int32 count,UInt32* value);
			internal unsafe static Uniform2uiv glUniform2uiv;
			
			internal delegate void Uniform3d(Int32 location,Double x,Double y,Double z);
			internal static Uniform3d glUniform3d;
			
			internal unsafe delegate void Uniform3dv(Int32 location,Int32 count,Double* value);
			internal unsafe static Uniform3dv glUniform3dv;
			
			internal delegate void Uniform3f(Int32 location,Single v0,Single v1,Single v2);
			internal static Uniform3f glUniform3f;
			
			internal unsafe delegate void Uniform3fv(Int32 location,Int32 count,Single* value);
			internal unsafe static Uniform3fv glUniform3fv;
			
			internal delegate void Uniform3i(Int32 location,Int32 v0,Int32 v1,Int32 v2);
			internal static Uniform3i glUniform3i;
			
			internal unsafe delegate void Uniform3iv(Int32 location,Int32 count,Int32* value);
			internal unsafe static Uniform3iv glUniform3iv;
			
			internal delegate void Uniform3ui(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
			internal static Uniform3ui glUniform3ui;
			
			internal unsafe delegate void Uniform3uiv(Int32 location,Int32 count,UInt32* value);
			internal unsafe static Uniform3uiv glUniform3uiv;
			
			internal delegate void Uniform4d(Int32 location,Double x,Double y,Double z,Double w);
			internal static Uniform4d glUniform4d;
			
			internal unsafe delegate void Uniform4dv(Int32 location,Int32 count,Double* value);
			internal unsafe static Uniform4dv glUniform4dv;
			
			internal delegate void Uniform4f(Int32 location,Single v0,Single v1,Single v2,Single v3);
			internal static Uniform4f glUniform4f;
			
			internal unsafe delegate void Uniform4fv(Int32 location,Int32 count,Single* value);
			internal unsafe static Uniform4fv glUniform4fv;
			
			internal delegate void Uniform4i(Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
			internal static Uniform4i glUniform4i;
			
			internal unsafe delegate void Uniform4iv(Int32 location,Int32 count,Int32* value);
			internal unsafe static Uniform4iv glUniform4iv;
			
			internal delegate void Uniform4ui(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
			internal static Uniform4ui glUniform4ui;
			
			internal unsafe delegate void Uniform4uiv(Int32 location,Int32 count,UInt32* value);
			internal unsafe static Uniform4uiv glUniform4uiv;
			
			internal delegate void UniformBlockBinding(UInt32 program,UInt32 uniformBlockIndex,UInt32 uniformBlockBinding);
			internal static UniformBlockBinding glUniformBlockBinding;
			
			internal unsafe delegate void UniformMatrix2dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix2dv glUniformMatrix2dv;
			
			internal unsafe delegate void UniformMatrix2fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
			
			internal unsafe delegate void UniformMatrix2x3dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv;
			
			internal unsafe delegate void UniformMatrix2x3fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
			
			internal unsafe delegate void UniformMatrix2x4dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv;
			
			internal unsafe delegate void UniformMatrix2x4fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
			
			internal unsafe delegate void UniformMatrix3dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix3dv glUniformMatrix3dv;
			
			internal unsafe delegate void UniformMatrix3fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
			
			internal unsafe delegate void UniformMatrix3x2dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv;
			
			internal unsafe delegate void UniformMatrix3x2fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
			
			internal unsafe delegate void UniformMatrix3x4dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv;
			
			internal unsafe delegate void UniformMatrix3x4fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
			
			internal unsafe delegate void UniformMatrix4dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix4dv glUniformMatrix4dv;
			
			internal unsafe delegate void UniformMatrix4fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
			
			internal unsafe delegate void UniformMatrix4x2dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv;
			
			internal unsafe delegate void UniformMatrix4x2fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
			
			internal unsafe delegate void UniformMatrix4x3dv(Int32 location,Int32 count,bool transpose,Double* value);
			internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv;
			
			internal unsafe delegate void UniformMatrix4x3fv(Int32 location,Int32 count,bool transpose,Single* value);
			internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
			
			internal unsafe delegate void UniformSubroutinesuiv(Pencil.Gaming.Graphics.ShaderType shadertype,Int32 count,UInt32* indices);
			internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv;
			
			internal delegate bool UnmapBuffer(Pencil.Gaming.Graphics.BufferTarget target);
			internal static UnmapBuffer glUnmapBuffer;
			
			internal delegate void UseProgram(UInt32 program);
			internal static UseProgram glUseProgram;
			
			internal delegate void UseProgramStages(UInt32 pipeline,Pencil.Gaming.Graphics.ProgramStageMask stages,UInt32 program);
			internal static UseProgramStages glUseProgramStages;
			
			internal delegate void ValidateProgram(UInt32 program);
			internal static ValidateProgram glValidateProgram;
			
			internal delegate void ValidateProgramPipeline(UInt32 pipeline);
			internal static ValidateProgramPipeline glValidateProgramPipeline;
			
			internal delegate void Vertex2d(Double x,Double y);
			internal static Vertex2d glVertex2d;
			
			internal unsafe delegate void Vertex2dv(Double* v);
			internal unsafe static Vertex2dv glVertex2dv;
			
			internal delegate void Vertex2f(Single x,Single y);
			internal static Vertex2f glVertex2f;
			
			internal unsafe delegate void Vertex2fv(Single* v);
			internal unsafe static Vertex2fv glVertex2fv;
			
			internal delegate void Vertex2i(Int32 x,Int32 y);
			internal static Vertex2i glVertex2i;
			
			internal unsafe delegate void Vertex2iv(Int32* v);
			internal unsafe static Vertex2iv glVertex2iv;
			
			internal delegate void Vertex2s(Int16 x,Int16 y);
			internal static Vertex2s glVertex2s;
			
			internal unsafe delegate void Vertex2sv(Int16* v);
			internal unsafe static Vertex2sv glVertex2sv;
			
			internal delegate void Vertex3d(Double x,Double y,Double z);
			internal static Vertex3d glVertex3d;
			
			internal unsafe delegate void Vertex3dv(Double* v);
			internal unsafe static Vertex3dv glVertex3dv;
			
			internal delegate void Vertex3f(Single x,Single y,Single z);
			internal static Vertex3f glVertex3f;
			
			internal unsafe delegate void Vertex3fv(Single* v);
			internal unsafe static Vertex3fv glVertex3fv;
			
			internal delegate void Vertex3i(Int32 x,Int32 y,Int32 z);
			internal static Vertex3i glVertex3i;
			
			internal unsafe delegate void Vertex3iv(Int32* v);
			internal unsafe static Vertex3iv glVertex3iv;
			
			internal delegate void Vertex3s(Int16 x,Int16 y,Int16 z);
			internal static Vertex3s glVertex3s;
			
			internal unsafe delegate void Vertex3sv(Int16* v);
			internal unsafe static Vertex3sv glVertex3sv;
			
			internal delegate void Vertex4d(Double x,Double y,Double z,Double w);
			internal static Vertex4d glVertex4d;
			
			internal unsafe delegate void Vertex4dv(Double* v);
			internal unsafe static Vertex4dv glVertex4dv;
			
			internal delegate void Vertex4f(Single x,Single y,Single z,Single w);
			internal static Vertex4f glVertex4f;
			
			internal unsafe delegate void Vertex4fv(Single* v);
			internal unsafe static Vertex4fv glVertex4fv;
			
			internal delegate void Vertex4i(Int32 x,Int32 y,Int32 z,Int32 w);
			internal static Vertex4i glVertex4i;
			
			internal unsafe delegate void Vertex4iv(Int32* v);
			internal unsafe static Vertex4iv glVertex4iv;
			
			internal delegate void Vertex4s(Int16 x,Int16 y,Int16 z,Int16 w);
			internal static Vertex4s glVertex4s;
			
			internal unsafe delegate void Vertex4sv(Int16* v);
			internal unsafe static Vertex4sv glVertex4sv;
			
			internal delegate void VertexAttrib1d(UInt32 index,Double x);
			internal static VertexAttrib1d glVertexAttrib1d;
			
			internal unsafe delegate void VertexAttrib1dv(UInt32 index,Double* v);
			internal unsafe static VertexAttrib1dv glVertexAttrib1dv;
			
			internal delegate void VertexAttrib1f(UInt32 index,Single x);
			internal static VertexAttrib1f glVertexAttrib1f;
			
			internal unsafe delegate void VertexAttrib1fv(UInt32 index,Single* v);
			internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
			
			internal delegate void VertexAttrib1s(UInt32 index,Int16 x);
			internal static VertexAttrib1s glVertexAttrib1s;
			
			internal unsafe delegate void VertexAttrib1sv(UInt32 index,Int16* v);
			internal unsafe static VertexAttrib1sv glVertexAttrib1sv;
			
			internal delegate void VertexAttrib2d(UInt32 index,Double x,Double y);
			internal static VertexAttrib2d glVertexAttrib2d;
			
			internal unsafe delegate void VertexAttrib2dv(UInt32 index,Double* v);
			internal unsafe static VertexAttrib2dv glVertexAttrib2dv;
			
			internal delegate void VertexAttrib2f(UInt32 index,Single x,Single y);
			internal static VertexAttrib2f glVertexAttrib2f;
			
			internal unsafe delegate void VertexAttrib2fv(UInt32 index,Single* v);
			internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
			
			internal delegate void VertexAttrib2s(UInt32 index,Int16 x,Int16 y);
			internal static VertexAttrib2s glVertexAttrib2s;
			
			internal unsafe delegate void VertexAttrib2sv(UInt32 index,Int16* v);
			internal unsafe static VertexAttrib2sv glVertexAttrib2sv;
			
			internal delegate void VertexAttrib3d(UInt32 index,Double x,Double y,Double z);
			internal static VertexAttrib3d glVertexAttrib3d;
			
			internal unsafe delegate void VertexAttrib3dv(UInt32 index,Double* v);
			internal unsafe static VertexAttrib3dv glVertexAttrib3dv;
			
			internal delegate void VertexAttrib3f(UInt32 index,Single x,Single y,Single z);
			internal static VertexAttrib3f glVertexAttrib3f;
			
			internal unsafe delegate void VertexAttrib3fv(UInt32 index,Single* v);
			internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
			
			internal delegate void VertexAttrib3s(UInt32 index,Int16 x,Int16 y,Int16 z);
			internal static VertexAttrib3s glVertexAttrib3s;
			
			internal unsafe delegate void VertexAttrib3sv(UInt32 index,Int16* v);
			internal unsafe static VertexAttrib3sv glVertexAttrib3sv;
			
			internal unsafe delegate void VertexAttrib4bv(UInt32 index,SByte* v);
			internal unsafe static VertexAttrib4bv glVertexAttrib4bv;
			
			internal delegate void VertexAttrib4d(UInt32 index,Double x,Double y,Double z,Double w);
			internal static VertexAttrib4d glVertexAttrib4d;
			
			internal unsafe delegate void VertexAttrib4dv(UInt32 index,Double* v);
			internal unsafe static VertexAttrib4dv glVertexAttrib4dv;
			
			internal delegate void VertexAttrib4f(UInt32 index,Single x,Single y,Single z,Single w);
			internal static VertexAttrib4f glVertexAttrib4f;
			
			internal unsafe delegate void VertexAttrib4fv(UInt32 index,Single* v);
			internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
			
			internal unsafe delegate void VertexAttrib4iv(UInt32 index,Int32* v);
			internal unsafe static VertexAttrib4iv glVertexAttrib4iv;
			
			internal unsafe delegate void VertexAttrib4Nbv(UInt32 index,SByte* v);
			internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv;
			
			internal unsafe delegate void VertexAttrib4Niv(UInt32 index,Int32* v);
			internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv;
			
			internal unsafe delegate void VertexAttrib4Nsv(UInt32 index,Int16* v);
			internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv;
			
			internal delegate void VertexAttrib4Nub(UInt32 index,Byte x,Byte y,Byte z,Byte w);
			internal static VertexAttrib4Nub glVertexAttrib4Nub;
			
			internal unsafe delegate void VertexAttrib4Nubv(UInt32 index,Byte* v);
			internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv;
			
			internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
			
			internal unsafe delegate void VertexAttrib4Nusv(UInt32 index,UInt16* v);
			internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv;
			
			internal delegate void VertexAttrib4s(UInt32 index,Int16 x,Int16 y,Int16 z,Int16 w);
			internal static VertexAttrib4s glVertexAttrib4s;
			
			internal unsafe delegate void VertexAttrib4sv(UInt32 index,Int16* v);
			internal unsafe static VertexAttrib4sv glVertexAttrib4sv;
			
			internal unsafe delegate void VertexAttrib4ubv(UInt32 index,Byte* v);
			internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv;
			
			internal unsafe delegate void VertexAttrib4uiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv;
			
			internal unsafe delegate void VertexAttrib4usv(UInt32 index,UInt16* v);
			internal unsafe static VertexAttrib4usv glVertexAttrib4usv;
			
			internal delegate void VertexAttribDivisor(UInt32 index,UInt32 divisor);
			internal static VertexAttribDivisor glVertexAttribDivisor;
			
			internal delegate void VertexAttribI1i(UInt32 index,Int32 x);
			internal static VertexAttribI1i glVertexAttribI1i;
			
			internal unsafe delegate void VertexAttribI1iv(UInt32 index,Int32* v);
			internal unsafe static VertexAttribI1iv glVertexAttribI1iv;
			
			internal delegate void VertexAttribI1ui(UInt32 index,UInt32 x);
			internal static VertexAttribI1ui glVertexAttribI1ui;
			
			internal unsafe delegate void VertexAttribI1uiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv;
			
			internal delegate void VertexAttribI2i(UInt32 index,Int32 x,Int32 y);
			internal static VertexAttribI2i glVertexAttribI2i;
			
			internal unsafe delegate void VertexAttribI2iv(UInt32 index,Int32* v);
			internal unsafe static VertexAttribI2iv glVertexAttribI2iv;
			
			internal delegate void VertexAttribI2ui(UInt32 index,UInt32 x,UInt32 y);
			internal static VertexAttribI2ui glVertexAttribI2ui;
			
			internal unsafe delegate void VertexAttribI2uiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv;
			
			internal delegate void VertexAttribI3i(UInt32 index,Int32 x,Int32 y,Int32 z);
			internal static VertexAttribI3i glVertexAttribI3i;
			
			internal unsafe delegate void VertexAttribI3iv(UInt32 index,Int32* v);
			internal unsafe static VertexAttribI3iv glVertexAttribI3iv;
			
			internal delegate void VertexAttribI3ui(UInt32 index,UInt32 x,UInt32 y,UInt32 z);
			internal static VertexAttribI3ui glVertexAttribI3ui;
			
			internal unsafe delegate void VertexAttribI3uiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv;
			
			internal unsafe delegate void VertexAttribI4bv(UInt32 index,SByte* v);
			internal unsafe static VertexAttribI4bv glVertexAttribI4bv;
			
			internal delegate void VertexAttribI4i(UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
			internal static VertexAttribI4i glVertexAttribI4i;
			
			internal unsafe delegate void VertexAttribI4iv(UInt32 index,Int32* v);
			internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
			
			internal unsafe delegate void VertexAttribI4sv(UInt32 index,Int16* v);
			internal unsafe static VertexAttribI4sv glVertexAttribI4sv;
			
			internal unsafe delegate void VertexAttribI4ubv(UInt32 index,Byte* v);
			internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv;
			
			internal delegate void VertexAttribI4ui(UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
			internal static VertexAttribI4ui glVertexAttribI4ui;
			
			internal unsafe delegate void VertexAttribI4uiv(UInt32 index,UInt32* v);
			internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
			
			internal unsafe delegate void VertexAttribI4usv(UInt32 index,UInt16* v);
			internal unsafe static VertexAttribI4usv glVertexAttribI4usv;
			
			internal delegate void VertexAttribIPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribIPointerType type,Int32 stride,IntPtr pointer);
			internal static VertexAttribIPointer glVertexAttribIPointer;
			
			internal delegate void VertexAttribL1d(UInt32 index,Double x);
			internal static VertexAttribL1d glVertexAttribL1d;
			
			internal unsafe delegate void VertexAttribL1dv(UInt32 index,Double* v);
			internal unsafe static VertexAttribL1dv glVertexAttribL1dv;
			
			internal delegate void VertexAttribL2d(UInt32 index,Double x,Double y);
			internal static VertexAttribL2d glVertexAttribL2d;
			
			internal unsafe delegate void VertexAttribL2dv(UInt32 index,Double* v);
			internal unsafe static VertexAttribL2dv glVertexAttribL2dv;
			
			internal delegate void VertexAttribL3d(UInt32 index,Double x,Double y,Double z);
			internal static VertexAttribL3d glVertexAttribL3d;
			
			internal unsafe delegate void VertexAttribL3dv(UInt32 index,Double* v);
			internal unsafe static VertexAttribL3dv glVertexAttribL3dv;
			
			internal delegate void VertexAttribL4d(UInt32 index,Double x,Double y,Double z,Double w);
			internal static VertexAttribL4d glVertexAttribL4d;
			
			internal unsafe delegate void VertexAttribL4dv(UInt32 index,Double* v);
			internal unsafe static VertexAttribL4dv glVertexAttribL4dv;
			
			internal delegate void VertexAttribLPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribDPointerType type,Int32 stride,IntPtr pointer);
			internal static VertexAttribLPointer glVertexAttribLPointer;
			
			internal delegate void VertexAttribP1ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
			internal static VertexAttribP1ui glVertexAttribP1ui;
			
			internal unsafe delegate void VertexAttribP1uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
			internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv;
			
			internal delegate void VertexAttribP2ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
			internal static VertexAttribP2ui glVertexAttribP2ui;
			
			internal unsafe delegate void VertexAttribP2uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
			internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv;
			
			internal delegate void VertexAttribP3ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
			internal static VertexAttribP3ui glVertexAttribP3ui;
			
			internal unsafe delegate void VertexAttribP3uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
			internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv;
			
			internal delegate void VertexAttribP4ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
			internal static VertexAttribP4ui glVertexAttribP4ui;
			
			internal unsafe delegate void VertexAttribP4uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
			internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv;
			
			internal delegate void VertexAttribPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribPointerType type,bool normalized,Int32 stride,IntPtr pointer);
			internal static VertexAttribPointer glVertexAttribPointer;
			
			internal delegate void VertexP2ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
			internal static VertexP2ui glVertexP2ui;
			
			internal unsafe delegate void VertexP2uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
			internal unsafe static VertexP2uiv glVertexP2uiv;
			
			internal delegate void VertexP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
			internal static VertexP3ui glVertexP3ui;
			
			internal unsafe delegate void VertexP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
			internal unsafe static VertexP3uiv glVertexP3uiv;
			
			internal delegate void VertexP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
			internal static VertexP4ui glVertexP4ui;
			
			internal unsafe delegate void VertexP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
			internal unsafe static VertexP4uiv glVertexP4uiv;
			
			internal delegate void VertexPointer(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,Int32 stride,IntPtr pointer);
			internal static VertexPointer glVertexPointer;
			
			internal delegate void Viewport(Int32 x,Int32 y,Int32 width,Int32 height);
			internal static Viewport glViewport;
			
			internal unsafe delegate void ViewportArrayv(UInt32 first,Int32 count,Single* v);
			internal unsafe static ViewportArrayv glViewportArrayv;
			
			internal delegate void ViewportIndexedf(UInt32 index,Single x,Single y,Single w,Single h);
			internal static ViewportIndexedf glViewportIndexedf;
			
			internal unsafe delegate void ViewportIndexedfv(UInt32 index,Single* v);
			internal unsafe static ViewportIndexedfv glViewportIndexedfv;
			
			internal delegate void WaitSync(IntPtr sync,UInt32 flags,UInt64 timeout);
			internal static WaitSync glWaitSync;
			
			internal delegate void WindowPos2d(Double x,Double y);
			internal static WindowPos2d glWindowPos2d;
			
			internal unsafe delegate void WindowPos2dv(Double* v);
			internal unsafe static WindowPos2dv glWindowPos2dv;
			
			internal delegate void WindowPos2f(Single x,Single y);
			internal static WindowPos2f glWindowPos2f;
			
			internal unsafe delegate void WindowPos2fv(Single* v);
			internal unsafe static WindowPos2fv glWindowPos2fv;
			
			internal delegate void WindowPos2i(Int32 x,Int32 y);
			internal static WindowPos2i glWindowPos2i;
			
			internal unsafe delegate void WindowPos2iv(Int32* v);
			internal unsafe static WindowPos2iv glWindowPos2iv;
			
			internal delegate void WindowPos2s(Int16 x,Int16 y);
			internal static WindowPos2s glWindowPos2s;
			
			internal unsafe delegate void WindowPos2sv(Int16* v);
			internal unsafe static WindowPos2sv glWindowPos2sv;
			
			internal delegate void WindowPos3d(Double x,Double y,Double z);
			internal static WindowPos3d glWindowPos3d;
			
			internal unsafe delegate void WindowPos3dv(Double* v);
			internal unsafe static WindowPos3dv glWindowPos3dv;
			
			internal delegate void WindowPos3f(Single x,Single y,Single z);
			internal static WindowPos3f glWindowPos3f;
			
			internal unsafe delegate void WindowPos3fv(Single* v);
			internal unsafe static WindowPos3fv glWindowPos3fv;
			
			internal delegate void WindowPos3i(Int32 x,Int32 y,Int32 z);
			internal static WindowPos3i glWindowPos3i;
			
			internal unsafe delegate void WindowPos3iv(Int32* v);
			internal unsafe static WindowPos3iv glWindowPos3iv;
			
			internal delegate void WindowPos3s(Int16 x,Int16 y,Int16 z);
			internal static WindowPos3s glWindowPos3s;
			
			internal unsafe delegate void WindowPos3sv(Int16* v);
			internal unsafe static WindowPos3sv glWindowPos3sv;
            // Manual add
            
            internal unsafe delegate void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            internal unsafe static DispatchCompute glDispatchCompute;
            
            internal unsafe delegate void DispatchComputeIndirect(IntPtr indirect);
            internal unsafe static DispatchComputeIndirect glDispatchComputeIndirect;
            
            internal unsafe delegate void MemoryBarrier(Pencil.Gaming.Graphics.MemoryBarrierMask barriers);
            internal unsafe static MemoryBarrier glMemoryBarrier;

		}
	}
}
