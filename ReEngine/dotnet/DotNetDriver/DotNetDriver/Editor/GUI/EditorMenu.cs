using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Common;
using DotNetAPId;
using ImGUILibd.ImGui;
using Worldd;

namespace DotNetDriver.Editor
{

    [AttributeUsage(AttributeTargets.Method)]
    public class MenuItemAttribute : Attribute
    {
        public string ItemName { get; }

        public MenuItemAttribute(string itemName)
        {
            ItemName = itemName;
        }

    }

    public class EditorMenu
    {
        private List<IEditorPanel> editorPanels;

        public void Init(List<IEditorPanel> editorPanels)
        {
            this.editorPanels = editorPanels;
            InitDynamicMenuItemTable();
        }

        
        private Dictionary<string, object> menuHashtable = new Dictionary<string, object>();

        public void OnGUI()
        {
            if (imgui.BeginMenuBar())
            {
                OnDynamicMenuItem();
            }
            imgui.EndMenuBar();
        }

        #region Files

        [MenuItem("Files/Open Scene")]
        public static void OpenScenes()
        {
            Log.Info("On Open Scene");
        }

        [MenuItem("Files/Save Scene")]
        public static void OnSaveScene()
        {
            Log.Info("On Save Scene");
        }

        [MenuItem("Files/Open Project")]
        public static void OpenProject()
        {
            ApplicationAPI.SelectProjectRoot();
        }

        #endregion

        #region GameObject

        [MenuItem("GameObject/Create Empty")]
        public static void CreateEmpty()
        {
            World.Get().CreateGameObject("Game Object", GameObjectFlag.None);
        }

        [MenuItem("GameObject/Create Camera")]
        public static void CreateCamera()
        {
            Log.Info("On Create Camera");
        }

        #endregion

        #region Help

        [MenuItem("Help/About")]
        public static void Help()
        {
            Log.Info("On About");
        }

        #endregion


        private void InitDynamicMenuItemTable()
        {
            Dictionary<string, MethodInfo> methodDict = new Dictionary<string, MethodInfo>();
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                var methods = type.GetMethods();
                foreach (var methodInfo in methods)
                {
                    if (methodInfo.HasAttribute(typeof(MenuItemAttribute)))
                    {
                        Log.Info(methodInfo.Name);
                        methodDict.Add(methodInfo.GetCustomAttribute<MenuItemAttribute>().ItemName, methodInfo);
                    }
                }
            }


            foreach (var (key, value) in methodDict)
            {
                var items = key.Split('/');
                var currentHashtable = menuHashtable;
                for (int i = 0; i < items.Length; i++)
                {
                    
                    if (i == items.Length - 1)
                    {
                        if (!currentHashtable.ContainsKey(items[i]))
                        {
                            currentHashtable.Add(items[i], value);
                        }
                        else
                        {
                            Log.Error("Already added menu item ", key);
                        }
                    }
                    else
                    {
                        if (currentHashtable.ContainsKey(items[i]))
                        {
                            currentHashtable = currentHashtable[items[i]] as Dictionary<string, object>;
                        }
                        else
                        {
                            var newHashTable = new Dictionary<string, object>();
                            currentHashtable.Add(items[i], newHashTable);
                            currentHashtable = newHashTable;
                        }
                       
                    }
                }
            }
        }

        private void OnDynamicMenuItem()
        {
            foreach (var (key, value) in menuHashtable)
            {
                if (imgui.BeginMenu(key, true))
                {
                    if (value is Dictionary<string, object> itemTable)
                    {
                        DrawMenuItems(itemTable);
                    }
                    imgui.EndMenu();
                }
            }
        }

        private void DrawMenuItems(Dictionary<string, object> itemMenuTable)
        {
            foreach (var (key, value) in itemMenuTable)
            {
                if (value is MethodInfo methodInfo)
                {
                    if (imgui.MenuItem(key, "", false, true))
                    {
                        methodInfo.Invoke(null, Array.Empty<object>());
                    }
                }
                else if(value is Dictionary<string, object> itemTable)
                {
                    if (imgui.BeginMenu(key, true))
                    {
                        DrawMenuItems(itemTable);
                    }
                    imgui.EndMenu();
                }
            }
        }
    }
}