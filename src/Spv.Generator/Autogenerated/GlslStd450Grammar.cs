// AUTOGENERATED: DO NOT EDIT
// Last update date: 2021-01-06 23:02:26.955269
#region Grammar License
// Copyright (c) 2014-2016 The Khronos Group Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and/or associated documentation files (the "Materials"),
// to deal in the Materials without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Materials, and to permit persons to whom the
// Materials are furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Materials.
// 
// MODIFICATIONS TO THIS FILE MAY MEAN IT NO LONGER ACCURATELY REFLECTS KHRONOS
// STANDARDS. THE UNMODIFIED, NORMATIVE VERSIONS OF KHRONOS SPECIFICATIONS AND
// HEADER INFORMATION ARE LOCATED AT https://www.khronos.org/registry/ 
// 
// THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM,OUT OF OR IN CONNECTION WITH THE MATERIALS OR THE USE OR OTHER DEALINGS
// IN THE MATERIALS.
#endregion

namespace Spv.Generator
{
    public partial class Module
    {
        public Instruction GlslRound(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 1, x);
        }

        public Instruction GlslRoundEven(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 2, x);
        }

        public Instruction GlslTrunc(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 3, x);
        }

        public Instruction GlslFAbs(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 4, x);
        }

        public Instruction GlslSAbs(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 5, x);
        }

        public Instruction GlslFSign(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 6, x);
        }

        public Instruction GlslSSign(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 7, x);
        }

        public Instruction GlslFloor(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 8, x);
        }

        public Instruction GlslCeil(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 9, x);
        }

        public Instruction GlslFract(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 10, x);
        }

        public Instruction GlslRadians(Instruction resultType, Instruction degrees)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 11, degrees);
        }

        public Instruction GlslDegrees(Instruction resultType, Instruction radians)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 12, radians);
        }

        public Instruction GlslSin(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 13, x);
        }

        public Instruction GlslCos(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 14, x);
        }

        public Instruction GlslTan(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 15, x);
        }

        public Instruction GlslAsin(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 16, x);
        }

        public Instruction GlslAcos(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 17, x);
        }

        public Instruction GlslAtan(Instruction resultType, Instruction y_over_x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 18, y_over_x);
        }

        public Instruction GlslSinh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 19, x);
        }

        public Instruction GlslCosh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 20, x);
        }

        public Instruction GlslTanh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 21, x);
        }

        public Instruction GlslAsinh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 22, x);
        }

        public Instruction GlslAcosh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 23, x);
        }

        public Instruction GlslAtanh(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 24, x);
        }

        public Instruction GlslAtan2(Instruction resultType, Instruction y, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 25, y, x);
        }

        public Instruction GlslPow(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 26, x, y);
        }

        public Instruction GlslExp(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 27, x);
        }

        public Instruction GlslLog(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 28, x);
        }

        public Instruction GlslExp2(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 29, x);
        }

        public Instruction GlslLog2(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 30, x);
        }

        public Instruction GlslSqrt(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 31, x);
        }

        public Instruction GlslInverseSqrt(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 32, x);
        }

        public Instruction GlslDeterminant(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 33, x);
        }

        public Instruction GlslMatrixInverse(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 34, x);
        }

        public Instruction GlslModf(Instruction resultType, Instruction x, Instruction i)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 35, x, i);
        }

        public Instruction GlslModfStruct(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 36, x);
        }

        public Instruction GlslFMin(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 37, x, y);
        }

        public Instruction GlslUMin(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 38, x, y);
        }

        public Instruction GlslSMin(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 39, x, y);
        }

        public Instruction GlslFMax(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 40, x, y);
        }

        public Instruction GlslUMax(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 41, x, y);
        }

        public Instruction GlslSMax(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 42, x, y);
        }

        public Instruction GlslFClamp(Instruction resultType, Instruction x, Instruction minVal, Instruction maxVal)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 43, x, minVal, maxVal);
        }

        public Instruction GlslUClamp(Instruction resultType, Instruction x, Instruction minVal, Instruction maxVal)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 44, x, minVal, maxVal);
        }

        public Instruction GlslSClamp(Instruction resultType, Instruction x, Instruction minVal, Instruction maxVal)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 45, x, minVal, maxVal);
        }

        public Instruction GlslFMix(Instruction resultType, Instruction x, Instruction y, Instruction a)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 46, x, y, a);
        }

        public Instruction GlslIMix(Instruction resultType, Instruction x, Instruction y, Instruction a)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 47, x, y, a);
        }

        public Instruction GlslStep(Instruction resultType, Instruction edge, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 48, edge, x);
        }

        public Instruction GlslSmoothStep(Instruction resultType, Instruction edge0, Instruction edge1, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 49, edge0, edge1, x);
        }

        public Instruction GlslFma(Instruction resultType, Instruction a, Instruction b, Instruction c)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 50, a, b, c);
        }

        public Instruction GlslFrexp(Instruction resultType, Instruction x, Instruction exp)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 51, x, exp);
        }

        public Instruction GlslFrexpStruct(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 52, x);
        }

        public Instruction GlslLdexp(Instruction resultType, Instruction x, Instruction exp)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 53, x, exp);
        }

        public Instruction GlslPackSnorm4x8(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 54, v);
        }

        public Instruction GlslPackUnorm4x8(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 55, v);
        }

        public Instruction GlslPackSnorm2x16(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 56, v);
        }

        public Instruction GlslPackUnorm2x16(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 57, v);
        }

        public Instruction GlslPackHalf2x16(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 58, v);
        }

        public Instruction GlslPackDouble2x32(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 59, v);
        }

        public Instruction GlslUnpackSnorm2x16(Instruction resultType, Instruction p)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 60, p);
        }

        public Instruction GlslUnpackUnorm2x16(Instruction resultType, Instruction p)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 61, p);
        }

        public Instruction GlslUnpackHalf2x16(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 62, v);
        }

        public Instruction GlslUnpackSnorm4x8(Instruction resultType, Instruction p)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 63, p);
        }

        public Instruction GlslUnpackUnorm4x8(Instruction resultType, Instruction p)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 64, p);
        }

        public Instruction GlslUnpackDouble2x32(Instruction resultType, Instruction v)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 65, v);
        }

        public Instruction GlslLength(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 66, x);
        }

        public Instruction GlslDistance(Instruction resultType, Instruction p0, Instruction p1)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 67, p0, p1);
        }

        public Instruction GlslCross(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 68, x, y);
        }

        public Instruction GlslNormalize(Instruction resultType, Instruction x)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 69, x);
        }

        public Instruction GlslFaceForward(Instruction resultType, Instruction n, Instruction i, Instruction nref)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 70, n, i, nref);
        }

        public Instruction GlslReflect(Instruction resultType, Instruction i, Instruction n)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 71, i, n);
        }

        public Instruction GlslRefract(Instruction resultType, Instruction i, Instruction n, Instruction eta)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 72, i, n, eta);
        }

        public Instruction GlslFindILsb(Instruction resultType, Instruction value)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 73, value);
        }

        public Instruction GlslFindSMsb(Instruction resultType, Instruction value)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 74, value);
        }

        public Instruction GlslFindUMsb(Instruction resultType, Instruction value)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 75, value);
        }

        public Instruction GlslInterpolateAtCentroid(Instruction resultType, Instruction interpolant)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 76, interpolant);
        }

        public Instruction GlslInterpolateAtSample(Instruction resultType, Instruction interpolant, Instruction sample)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 77, interpolant, sample);
        }

        public Instruction GlslInterpolateAtOffset(Instruction resultType, Instruction interpolant, Instruction offset)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 78, interpolant, offset);
        }

        public Instruction GlslNMin(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 79, x, y);
        }

        public Instruction GlslNMax(Instruction resultType, Instruction x, Instruction y)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 80, x, y);
        }

        public Instruction GlslNClamp(Instruction resultType, Instruction x, Instruction minVal, Instruction maxVal)
        {
            return ExtInst(resultType, AddExtInstImport("GLSL.std.450"), 81, x, minVal, maxVal);
        }

    }
}
