#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


// Gvr.Internal.EmulatorConfig
struct EmulatorConfig_t3552469519;
// proto.PhoneEvent/Types/MotionEvent/Types/Pointer
struct Pointer_t1264047646;
// GvrEye
struct GvrEye_t2145111534;

#include "mscorlib_System_Array2840145358.h"
#include "AssemblyU2DCSharp_GvrAudioRoom_SurfaceMaterial459108564.h"
#include "AssemblyU2DCSharp_Gvr_Internal_EmulatorTouchEvent_1264047645.h"
#include "AssemblyU2DCSharp_Gvr_Internal_EmulatorConfig3552469519.h"
#include "AssemblyU2DCSharp_proto_PhoneEvent_Types_MotionEve1264047645.h"
#include "AssemblyU2DCSharp_GvrEye2145111534.h"

#pragma once
// GvrAudioRoom/SurfaceMaterial[]
struct SurfaceMaterialU5BU5D_t3915230557  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline int32_t* GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// Gvr.Internal.EmulatorTouchEvent/Pointer[]
struct PointerU5BU5D_t1307870416  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) Pointer_t1264047645  m_Items[1];

public:
	inline Pointer_t1264047645  GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline Pointer_t1264047645 * GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, Pointer_t1264047645  value)
	{
		m_Items[index] = value;
	}
};
// Gvr.Internal.EmulatorConfig[]
struct EmulatorConfigU5BU5D_t76636374  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) EmulatorConfig_t3552469519 * m_Items[1];

public:
	inline EmulatorConfig_t3552469519 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline EmulatorConfig_t3552469519 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, EmulatorConfig_t3552469519 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// proto.PhoneEvent/Types/MotionEvent/Types/Pointer[]
struct PointerU5BU5D_t1307870417  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) Pointer_t1264047646 * m_Items[1];

public:
	inline Pointer_t1264047646 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline Pointer_t1264047646 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, Pointer_t1264047646 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// GvrEye[]
struct GvrEyeU5BU5D_t2613429915  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) GvrEye_t2145111534 * m_Items[1];

public:
	inline GvrEye_t2145111534 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline GvrEye_t2145111534 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, GvrEye_t2145111534 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
