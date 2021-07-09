#include <imgui.h>
#include <imstb_rectpack.h>
#include <imstb_textedit.h>
#include <imstb_truetype.h>
#include <TestOpenGL_API.h>
#include <DotNetAPI/NetLog.h>
#include <new>

extern "C" __declspec(dllexport) void ImVec2_ImVec2(void* __instance) { ::new (__instance) ImVec2(); }
extern "C" __declspec(dllexport) void ImVec2_ImVec2_f_f(void* __instance, float _x, float _y) { ::new (__instance) ImVec2(_x, _y); }
float& (ImVec2::*_0)(unsigned long long) = &ImVec2::operator[];
ImVec2& (ImVec2::*_1)(ImVec2&&) = &ImVec2::operator=;
extern "C" __declspec(dllexport) void ImVec4_ImVec4(void* __instance) { ::new (__instance) ImVec4(); }
extern "C" __declspec(dllexport) void ImVec4_ImVec4_f_f_f_f(void* __instance, float _x, float _y, float _z, float _w) { ::new (__instance) ImVec4(_x, _y, _z, _w); }
ImVec4& (ImVec4::*_2)(ImVec4&&) = &ImVec4::operator=;
ImNewWrapper& (ImNewWrapper::*_3)(ImNewWrapper&&) = &ImNewWrapper::operator=;
ImGuiStyle& (ImGuiStyle::*_4)(ImGuiStyle&&) = &ImGuiStyle::operator=;
extern "C" __declspec(dllexport) void ImGuiIO_ImGuiIO___1__S_ImGuiIO(void* __instance, const ImGuiIO& _0) { ::new (__instance) ImGuiIO(_0); }
ImGuiIO& (ImGuiIO::*_5)(ImGuiIO&&) = &ImGuiIO::operator=;
extern "C" __declspec(dllexport) void ImGuiIO__ImGuiIO(ImGuiIO*__instance) { __instance->~ImGuiIO(); }
void (ImGuiInputTextCallbackData::*_6)() = &ImGuiInputTextCallbackData::SelectAll;
void (ImGuiInputTextCallbackData::*_7)() = &ImGuiInputTextCallbackData::ClearSelection;
bool (ImGuiInputTextCallbackData::*_8)() const = &ImGuiInputTextCallbackData::HasSelection;
ImGuiInputTextCallbackData& (ImGuiInputTextCallbackData::*_9)(ImGuiInputTextCallbackData&&) = &ImGuiInputTextCallbackData::operator=;
extern "C" __declspec(dllexport) void ImGuiSizeCallbackData_ImGuiSizeCallbackData(void* __instance) { ::new (__instance) ImGuiSizeCallbackData(); }
ImGuiSizeCallbackData& (ImGuiSizeCallbackData::*_10)(ImGuiSizeCallbackData&&) = &ImGuiSizeCallbackData::operator=;
extern "C" __declspec(dllexport) void ImGuiWindowClass_ImGuiWindowClass(void* __instance) { ::new (__instance) ImGuiWindowClass(); }
ImGuiWindowClass& (ImGuiWindowClass::*_11)(ImGuiWindowClass&&) = &ImGuiWindowClass::operator=;
extern "C" __declspec(dllexport) void ImGuiPayload_ImGuiPayload(void* __instance) { ::new (__instance) ImGuiPayload(); }
void (ImGuiPayload::*_12)() = &ImGuiPayload::Clear;
bool (ImGuiPayload::*_13)(const char*) const = &ImGuiPayload::IsDataType;
bool (ImGuiPayload::*_14)() const = &ImGuiPayload::IsPreview;
bool (ImGuiPayload::*_15)() const = &ImGuiPayload::IsDelivery;
ImGuiPayload& (ImGuiPayload::*_16)(ImGuiPayload&&) = &ImGuiPayload::operator=;
extern "C" __declspec(dllexport) void ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs(void* __instance) { ::new (__instance) ImGuiTableColumnSortSpecs(); }
ImGuiTableColumnSortSpecs& (ImGuiTableColumnSortSpecs::*_17)(ImGuiTableColumnSortSpecs&&) = &ImGuiTableColumnSortSpecs::operator=;
extern "C" __declspec(dllexport) void ImGuiTableSortSpecs_ImGuiTableSortSpecs(void* __instance) { ::new (__instance) ImGuiTableSortSpecs(); }
ImGuiTableSortSpecs& (ImGuiTableSortSpecs::*_18)(ImGuiTableSortSpecs&&) = &ImGuiTableSortSpecs::operator=;
extern "C" __declspec(dllexport) void ImGuiOnceUponAFrame_ImGuiOnceUponAFrame(void* __instance) { ::new (__instance) ImGuiOnceUponAFrame(); }
bool (ImGuiOnceUponAFrame::*_19)() const = &ImGuiOnceUponAFrame::operator bool;
ImGuiOnceUponAFrame& (ImGuiOnceUponAFrame::*_20)(ImGuiOnceUponAFrame&&) = &ImGuiOnceUponAFrame::operator=;
extern "C" __declspec(dllexport) void ImGuiTextFilter_S_ImGuiTextRange_ImGuiTextRange(void* __instance) { ::new (__instance) ImGuiTextFilter::ImGuiTextRange(); }
extern "C" __declspec(dllexport) void ImGuiTextFilter_S_ImGuiTextRange_ImGuiTextRange__1C_S0(void* __instance, const char* _b, const char* _e) { ::new (__instance) ImGuiTextFilter::ImGuiTextRange(_b, _e); }
bool (ImGuiTextFilter::ImGuiTextRange::*_21)() const = &ImGuiTextFilter::ImGuiTextRange::empty;
ImGuiTextFilter::ImGuiTextRange& (ImGuiTextFilter::ImGuiTextRange::*_22)(ImGuiTextFilter::ImGuiTextRange&&) = &ImGuiTextFilter::ImGuiTextRange::operator=;
void (ImGuiTextFilter::*_23)() = &ImGuiTextFilter::Clear;
bool (ImGuiTextFilter::*_24)() const = &ImGuiTextFilter::IsActive;
extern "C" __declspec(dllexport) void ImGuiTextFilter_ImGuiTextFilter___1__S_ImGuiTextFilter(void* __instance, const ImGuiTextFilter& _0) { ::new (__instance) ImGuiTextFilter(_0); }
ImGuiTextFilter& (ImGuiTextFilter::*_25)(ImGuiTextFilter&&) = &ImGuiTextFilter::operator=;
extern "C" __declspec(dllexport) void ImGuiTextFilter__ImGuiTextFilter(ImGuiTextFilter*__instance) { __instance->~ImGuiTextFilter(); }
extern "C" __declspec(dllexport) void ImGuiTextBuffer_ImGuiTextBuffer(void* __instance) { ::new (__instance) ImGuiTextBuffer(); }
char (ImGuiTextBuffer::*_26)(int) const = &ImGuiTextBuffer::operator[];
const char* (ImGuiTextBuffer::*_27)() const = &ImGuiTextBuffer::begin;
const char* (ImGuiTextBuffer::*_28)() const = &ImGuiTextBuffer::end;
int (ImGuiTextBuffer::*_29)() const = &ImGuiTextBuffer::size;
bool (ImGuiTextBuffer::*_30)() const = &ImGuiTextBuffer::empty;
void (ImGuiTextBuffer::*_31)() = &ImGuiTextBuffer::clear;
void (ImGuiTextBuffer::*_32)(int) = &ImGuiTextBuffer::reserve;
const char* (ImGuiTextBuffer::*_33)() const = &ImGuiTextBuffer::c_str;
extern "C" __declspec(dllexport) void ImGuiTextBuffer_ImGuiTextBuffer___1__S_ImGuiTextBuffer(void* __instance, const ImGuiTextBuffer& _0) { ::new (__instance) ImGuiTextBuffer(_0); }
ImGuiTextBuffer& (ImGuiTextBuffer::*_34)(ImGuiTextBuffer&&) = &ImGuiTextBuffer::operator=;
extern "C" __declspec(dllexport) void ImGuiTextBuffer__ImGuiTextBuffer(ImGuiTextBuffer*__instance) { __instance->~ImGuiTextBuffer(); }
extern "C" __declspec(dllexport) void ImGuiStorage_S_ImGuiStoragePair_ImGuiStoragePair_i_I(void* __instance, unsigned int _key, int _val_i) { ::new (__instance) ImGuiStorage::ImGuiStoragePair(_key, _val_i); }
extern "C" __declspec(dllexport) void ImGuiStorage_S_ImGuiStoragePair_ImGuiStoragePair_i_f(void* __instance, unsigned int _key, float _val_f) { ::new (__instance) ImGuiStorage::ImGuiStoragePair(_key, _val_f); }
extern "C" __declspec(dllexport) void ImGuiStorage_S_ImGuiStoragePair_ImGuiStoragePair_i__v(void* __instance, unsigned int _key, void* _val_p) { ::new (__instance) ImGuiStorage::ImGuiStoragePair(_key, _val_p); }
ImGuiStorage::ImGuiStoragePair& (ImGuiStorage::ImGuiStoragePair::*_35)(ImGuiStorage::ImGuiStoragePair&&) = &ImGuiStorage::ImGuiStoragePair::operator=;
void (ImGuiStorage::*_36)() = &ImGuiStorage::Clear;
extern "C" __declspec(dllexport) void ImGuiStorage_ImGuiStorage___1__S_ImGuiStorage(void* __instance, const ImGuiStorage& _0) { ::new (__instance) ImGuiStorage(_0); }
ImGuiStorage& (ImGuiStorage::*_37)(ImGuiStorage&&) = &ImGuiStorage::operator=;
extern "C" __declspec(dllexport) void ImGuiStorage__ImGuiStorage(ImGuiStorage*__instance) { __instance->~ImGuiStorage(); }
extern "C" __declspec(dllexport) void ImGuiStorage_ImGuiStorage(void* __instance) { ::new (__instance) ImGuiStorage(); }
extern "C" __declspec(dllexport) void ImGuiListClipper_ImGuiListClipper_I_f(void* __instance, int items_count, float items_height) { ::new (__instance) ImGuiListClipper(items_count, items_height); }
ImGuiListClipper& (ImGuiListClipper::*_38)(const ImGuiListClipper&) = &ImGuiListClipper::operator=;
extern "C" __declspec(dllexport) void ImColor_ImColor(void* __instance) { ::new (__instance) ImColor(); }
extern "C" __declspec(dllexport) void ImColor_ImColor_I_I_I_I(void* __instance, int r, int g, int b, int a) { ::new (__instance) ImColor(r, g, b, a); }
extern "C" __declspec(dllexport) void ImColor_ImColor_i(void* __instance, unsigned int rgba) { ::new (__instance) ImColor(rgba); }
extern "C" __declspec(dllexport) void ImColor_ImColor_f_f_f_f(void* __instance, float r, float g, float b, float a) { ::new (__instance) ImColor(r, g, b, a); }
extern "C" __declspec(dllexport) void ImColor_ImColor___1__S_ImVec4(void* __instance, const ImVec4& col) { ::new (__instance) ImColor(col); }
unsigned int (ImColor::*_39)() const = &ImColor::operator unsigned int;
ImVec4 (ImColor::*_40)() const = &ImColor::operator ImVec4;
void (ImColor::*_41)(float, float, float, float) = &ImColor::SetHSV;
ImColor (*_42)(float, float, float, float) = &ImColor::HSV;
ImColor& (ImColor::*_43)(ImColor&&) = &ImColor::operator=;
extern "C" __declspec(dllexport) void ImDrawCmd_ImDrawCmd(void* __instance) { ::new (__instance) ImDrawCmd(); }
void* (ImDrawCmd::*_44)() const = &ImDrawCmd::GetTexID;
ImDrawCmd& (ImDrawCmd::*_45)(ImDrawCmd&&) = &ImDrawCmd::operator=;
extern "C" __declspec(dllexport) void ImDrawVert_ImDrawVert(void* __instance) { ::new (__instance) ImDrawVert(); }
ImDrawVert& (ImDrawVert::*_46)(ImDrawVert&&) = &ImDrawVert::operator=;
ImDrawCmdHeader& (ImDrawCmdHeader::*_47)(ImDrawCmdHeader&&) = &ImDrawCmdHeader::operator=;
extern "C" __declspec(dllexport) void ImDrawCmdHeader_ImDrawCmdHeader(void* __instance) { ::new (__instance) ImDrawCmdHeader(); }
extern "C" __declspec(dllexport) void ImDrawChannel_ImDrawChannel___1__S_ImDrawChannel(void* __instance, const ImDrawChannel& _0) { ::new (__instance) ImDrawChannel(_0); }
ImDrawChannel& (ImDrawChannel::*_48)(ImDrawChannel&&) = &ImDrawChannel::operator=;
extern "C" __declspec(dllexport) void ImDrawChannel__ImDrawChannel(ImDrawChannel*__instance) { __instance->~ImDrawChannel(); }
extern "C" __declspec(dllexport) void ImDrawChannel_ImDrawChannel(void* __instance) { ::new (__instance) ImDrawChannel(); }
extern "C" __declspec(dllexport) void ImDrawListSplitter_ImDrawListSplitter(void* __instance) { ::new (__instance) ImDrawListSplitter(); }
extern "C" __declspec(dllexport) void ImDrawListSplitter__ImDrawListSplitter(ImDrawListSplitter*__instance) { __instance->~ImDrawListSplitter(); }
void (ImDrawListSplitter::*_49)() = &ImDrawListSplitter::Clear;
extern "C" __declspec(dllexport) void ImDrawListSplitter_ImDrawListSplitter___1__S_ImDrawListSplitter(void* __instance, const ImDrawListSplitter& _0) { ::new (__instance) ImDrawListSplitter(_0); }
ImDrawListSplitter& (ImDrawListSplitter::*_50)(const ImDrawListSplitter&) = &ImDrawListSplitter::operator=;
extern "C" __declspec(dllexport) void ImDrawList_ImDrawList__1__S_ImDrawListSharedData(void* __instance, const ImDrawListSharedData* shared_data) { ::new (__instance) ImDrawList(shared_data); }
extern "C" __declspec(dllexport) void ImDrawList__ImDrawList(ImDrawList*__instance) { __instance->~ImDrawList(); }
ImVec2 (ImDrawList::*_51)() const = &ImDrawList::GetClipRectMin;
ImVec2 (ImDrawList::*_52)() const = &ImDrawList::GetClipRectMax;
void (ImDrawList::*_53)() = &ImDrawList::PathClear;
void (ImDrawList::*_54)(const ImVec2&) = &ImDrawList::PathLineTo;
void (ImDrawList::*_55)(const ImVec2&) = &ImDrawList::PathLineToMergeDuplicate;
void (ImDrawList::*_56)(unsigned int) = &ImDrawList::PathFillConvex;
void (ImDrawList::*_57)(unsigned int, int, float) = &ImDrawList::PathStroke;
void (ImDrawList::*_58)(int) = &ImDrawList::ChannelsSplit;
void (ImDrawList::*_59)() = &ImDrawList::ChannelsMerge;
void (ImDrawList::*_60)(int) = &ImDrawList::ChannelsSetCurrent;
void (ImDrawList::*_61)(const ImVec2&, const ImVec2&, unsigned int) = &ImDrawList::PrimWriteVtx;
void (ImDrawList::*_62)(unsigned short) = &ImDrawList::PrimWriteIdx;
void (ImDrawList::*_63)(const ImVec2&, const ImVec2&, unsigned int) = &ImDrawList::PrimVtx;
void (ImDrawList::*_64)(const ImVec2&, const ImVec2&, const ImVec2&, const ImVec2&, unsigned int, float, int) = &ImDrawList::AddBezierCurve;
void (ImDrawList::*_65)(const ImVec2&, const ImVec2&, const ImVec2&, int) = &ImDrawList::PathBezierCurveTo;
extern "C" __declspec(dllexport) void ImDrawList_ImDrawList___1__S_ImDrawList(void* __instance, const ImDrawList& _0) { ::new (__instance) ImDrawList(_0); }
ImDrawList& (ImDrawList::*_66)(const ImDrawList&) = &ImDrawList::operator=;
extern "C" __declspec(dllexport) void ImDrawData_ImDrawData(void* __instance) { ::new (__instance) ImDrawData(); }
void (ImDrawData::*_67)() = &ImDrawData::Clear;
ImDrawData& (ImDrawData::*_68)(ImDrawData&&) = &ImDrawData::operator=;
ImFontConfig& (ImFontConfig::*_69)(ImFontConfig&&) = &ImFontConfig::operator=;
ImFontGlyph& (ImFontGlyph::*_70)(ImFontGlyph&&) = &ImFontGlyph::operator=;
extern "C" __declspec(dllexport) void ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder(void* __instance) { ::new (__instance) ImFontGlyphRangesBuilder(); }
void (ImFontGlyphRangesBuilder::*_71)() = &ImFontGlyphRangesBuilder::Clear;
bool (ImFontGlyphRangesBuilder::*_72)(unsigned long long) const = &ImFontGlyphRangesBuilder::GetBit;
void (ImFontGlyphRangesBuilder::*_73)(unsigned long long) = &ImFontGlyphRangesBuilder::SetBit;
void (ImFontGlyphRangesBuilder::*_74)(unsigned short) = &ImFontGlyphRangesBuilder::AddChar;
extern "C" __declspec(dllexport) void ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder___1__S_ImFontGlyphRangesBuilder(void* __instance, const ImFontGlyphRangesBuilder& _0) { ::new (__instance) ImFontGlyphRangesBuilder(_0); }
ImFontGlyphRangesBuilder& (ImFontGlyphRangesBuilder::*_75)(ImFontGlyphRangesBuilder&&) = &ImFontGlyphRangesBuilder::operator=;
extern "C" __declspec(dllexport) void ImFontGlyphRangesBuilder__ImFontGlyphRangesBuilder(ImFontGlyphRangesBuilder*__instance) { __instance->~ImFontGlyphRangesBuilder(); }
extern "C" __declspec(dllexport) void ImFontAtlasCustomRect_ImFontAtlasCustomRect(void* __instance) { ::new (__instance) ImFontAtlasCustomRect(); }
bool (ImFontAtlasCustomRect::*_76)() const = &ImFontAtlasCustomRect::IsPacked;
ImFontAtlasCustomRect& (ImFontAtlasCustomRect::*_77)(ImFontAtlasCustomRect&&) = &ImFontAtlasCustomRect::operator=;
bool (ImFontAtlas::*_78)() const = &ImFontAtlas::IsBuilt;
void (ImFontAtlas::*_79)(void*) = &ImFontAtlas::SetTexID;
ImFontAtlasCustomRect* (ImFontAtlas::*_80)(int) = &ImFontAtlas::GetCustomRectByIndex;
extern "C" __declspec(dllexport) void ImFontAtlas_ImFontAtlas___1__S_ImFontAtlas(void* __instance, const ImFontAtlas& _0) { ::new (__instance) ImFontAtlas(_0); }
ImFontAtlas& (ImFontAtlas::*_81)(const ImFontAtlas&) = &ImFontAtlas::operator=;
float (ImFont::*_82)(unsigned short) const = &ImFont::GetCharAdvance;
bool (ImFont::*_83)() const = &ImFont::IsLoaded;
const char* (ImFont::*_84)() const = &ImFont::GetDebugName;
extern "C" __declspec(dllexport) void ImFont_ImFont___1__S_ImFont(void* __instance, const ImFont& _0) { ::new (__instance) ImFont(_0); }
ImFont& (ImFont::*_85)(const ImFont&) = &ImFont::operator=;
extern "C" __declspec(dllexport) void ImGuiViewport_ImGuiViewport(void* __instance) { ::new (__instance) ImGuiViewport(); }
extern "C" __declspec(dllexport) void ImGuiViewport__ImGuiViewport(ImGuiViewport*__instance) { __instance->~ImGuiViewport(); }
ImVec2 (ImGuiViewport::*_86)() const = &ImGuiViewport::GetCenter;
ImVec2 (ImGuiViewport::*_87)() const = &ImGuiViewport::GetWorkCenter;
ImGuiViewport& (ImGuiViewport::*_88)(const ImGuiViewport&) = &ImGuiViewport::operator=;
extern "C" __declspec(dllexport) void ImGuiPlatformIO_ImGuiPlatformIO(void* __instance) { ::new (__instance) ImGuiPlatformIO(); }
extern "C" __declspec(dllexport) void ImGuiPlatformIO_ImGuiPlatformIO___1__S_ImGuiPlatformIO(void* __instance, const ImGuiPlatformIO& _0) { ::new (__instance) ImGuiPlatformIO(_0); }
ImGuiPlatformIO& (ImGuiPlatformIO::*_89)(ImGuiPlatformIO&&) = &ImGuiPlatformIO::operator=;
extern "C" __declspec(dllexport) void ImGuiPlatformIO__ImGuiPlatformIO(ImGuiPlatformIO*__instance) { __instance->~ImGuiPlatformIO(); }
extern "C" __declspec(dllexport) void ImGuiPlatformMonitor_ImGuiPlatformMonitor(void* __instance) { ::new (__instance) ImGuiPlatformMonitor(); }
ImGuiPlatformMonitor& (ImGuiPlatformMonitor::*_90)(ImGuiPlatformMonitor&&) = &ImGuiPlatformMonitor::operator=;
void* (*_91)(unsigned long long, ImNewWrapper, void*) = &operator new;
void (*_92)(void*, ImNewWrapper, void*) = &operator delete;
bool (*_93)(const char*, const ImVec2&) = &ImGui::ListBoxHeader;
void (*_94)() = &ImGui::ListBoxFooter;
void (*_95)(const char*, int) = &ImGui::OpenPopupContextItem;
bool (*_96)(const char*, float*, float, float, float, const char*, float) = &ImGui::DragFloat;
bool (*_97)(const char*, float[2], float, float, float, const char*, float) = &ImGui::DragFloat2;
bool (*_98)(const char*, float[3], float, float, float, const char*, float) = &ImGui::DragFloat3;
bool (*_99)(const char*, float[4], float, float, float, const char*, float) = &ImGui::DragFloat4;
bool (*_100)(const char*, float*, float, float, const char*, float) = &ImGui::SliderFloat;
bool (*_101)(const char*, float[2], float, float, const char*, float) = &ImGui::SliderFloat2;
bool (*_102)(const char*, float[3], float, float, const char*, float) = &ImGui::SliderFloat3;
bool (*_103)(const char*, float[4], float, float, const char*, float) = &ImGui::SliderFloat4;
bool (*_104)(const char*, int, bool) = &ImGui::BeginPopupContextWindow;
void (*_105)() = &ImGui::TreeAdvanceToLabelPos;
void (*_106)(bool, int) = &ImGui::SetNextTreeNodeOpen;
float (*_107)() = &ImGui::GetContentRegionAvailWidth;
ImDrawList* (*_108)() = &ImGui::GetOverlayDrawList;
stbrp_rect& (stbrp_rect::*_109)(stbrp_rect&&) = &stbrp_rect::operator=;
stbrp_node& (stbrp_node::*_110)(stbrp_node&&) = &stbrp_node::operator=;
stbrp_context& (stbrp_context::*_111)(stbrp_context&&) = &stbrp_context::operator=;
StbUndoRecord& (StbUndoRecord::*_112)(StbUndoRecord&&) = &StbUndoRecord::operator=;
StbUndoState& (StbUndoState::*_113)(StbUndoState&&) = &StbUndoState::operator=;
STB_TexteditState& (STB_TexteditState::*_114)(STB_TexteditState&&) = &STB_TexteditState::operator=;
StbTexteditRow& (StbTexteditRow::*_115)(StbTexteditRow&&) = &StbTexteditRow::operator=;
stbtt__buf& (stbtt__buf::*_116)(stbtt__buf&&) = &stbtt__buf::operator=;
stbtt_bakedchar& (stbtt_bakedchar::*_117)(stbtt_bakedchar&&) = &stbtt_bakedchar::operator=;
stbtt_aligned_quad& (stbtt_aligned_quad::*_118)(stbtt_aligned_quad&&) = &stbtt_aligned_quad::operator=;
stbtt_packedchar& (stbtt_packedchar::*_119)(stbtt_packedchar&&) = &stbtt_packedchar::operator=;
stbtt_pack_range& (stbtt_pack_range::*_120)(stbtt_pack_range&&) = &stbtt_pack_range::operator=;
stbtt_pack_context& (stbtt_pack_context::*_121)(stbtt_pack_context&&) = &stbtt_pack_context::operator=;
stbtt_fontinfo& (stbtt_fontinfo::*_122)(stbtt_fontinfo&&) = &stbtt_fontinfo::operator=;
stbtt_vertex& (stbtt_vertex::*_123)(stbtt_vertex&&) = &stbtt_vertex::operator=;
stbtt__bitmap& (stbtt__bitmap::*_124)(stbtt__bitmap&&) = &stbtt__bitmap::operator=;
NetLog& (NetLog::*_125)(NetLog&&) = &NetLog::operator=;
