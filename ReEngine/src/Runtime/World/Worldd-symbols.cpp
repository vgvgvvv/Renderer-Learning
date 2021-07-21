#include <Component.h>
#include <Behavior.h>
#include <DotNetBehavior.h>
#include <GameObject.h>
#include <World.h>
#include <World_API.h>
#include <Singleton.h>
#include <new>

Component& (Component::*_1)(const Component&) = &Component::operator=;
extern "C" __declspec(dllexport) void Component_Component(void* __instance) { ::new (__instance) Component(); }
extern "C" __declspec(dllexport) void Component_Component___1__S_Component(void* __instance, const Component& _0) { ::new (__instance) Component(_0); }
extern "C" __declspec(dllexport) void Behavior_Behavior___1__S_Behavior(void* __instance, const Behavior& _0) { ::new (__instance) Behavior(_0); }
Behavior& (Behavior::*_2)(Behavior&&) = &Behavior::operator=;
extern "C" __declspec(dllexport) void Behavior_Behavior(void* __instance) { ::new (__instance) Behavior(); }
BehaviorManager& (*_3)() = &BehaviorManager::Get;
extern "C" __declspec(dllexport) void BehaviorManager__BehaviorManager(BehaviorManager*__instance) { __instance->~BehaviorManager(); }
DotNetBehavior& (DotNetBehavior::*_4)(DotNetBehavior&&) = &DotNetBehavior::operator=;
extern "C" __declspec(dllexport) void DotNetBehavior_DotNetBehavior(void* __instance) { ::new (__instance) DotNetBehavior(); }
extern "C" __declspec(dllexport) void DotNetBehavior_DotNetBehavior___1__S_DotNetBehavior(void* __instance, const DotNetBehavior& _0) { ::new (__instance) DotNetBehavior(_0); }
void (GameObject::*_5)(const std::basic_string<char, std::char_traits<char>, std::allocator<char>>&) = &GameObject::SetName;
const std::basic_string<char, std::char_traits<char>, std::allocator<char>>& (GameObject::*_6)() const = &GameObject::GetName;
const GameObject* (GameObject::*_7)() const = &GameObject::GetParent;
extern "C" __declspec(dllexport) void GameObject_GameObject___1__S_GameObject(void* __instance, const GameObject& _0) { ::new (__instance) GameObject(_0); }
GameObject& (GameObject::*_8)(GameObject&&) = &GameObject::operator=;
extern "C" __declspec(dllexport) void GameObject__GameObject(GameObject*__instance) { __instance->~GameObject(); }
World& (*_9)() = &World::Get;
extern "C" __declspec(dllexport) void World__World(World*__instance) { __instance->~World(); }
