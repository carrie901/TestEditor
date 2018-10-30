using UnityEngine;
using System.Collections.Generic;

namespace Summer
{
    public class RuntimeLog : MonoBehaviour, I_Log
    {
        protected static RuntimeLog _instance;
        public static RuntimeLog Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "RuntimeLog";
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<RuntimeLog>();
                }

                return _instance;
            }
        }

        #region Log

        public void Log(string message)
        {
            _lines.Add(string.Format("[Log]:<color=#ffffff>  {0}</color>", message));
            LimitLogCount();
        }

        public void Log(string message, params object[] args)
        {
            _lines.Add(string.Format("[Log]:<color=#ffffff>  {0}</color>", string.Format(message, args)));
            LimitLogCount();
        }

        public void Waring(string message)
        {
            _lines.Add(string.Format("[Warning]:<color=#ffffff>  {0}</color>", message));
            LimitLogCount();
        }

        public void Warning(string message, params object[] args)
        {
            _lines.Add(string.Format("[Warning]:<color=#ffffff>  {0}</color>", string.Format(message, args)));
            LimitLogCount();
        }

        public void Error(string message)
        {
            _lines.Add(string.Format("[ERROR]:<color=#ff0000>  {0}</color>", message));
            LimitLogCount();
        }

        public void Error(string message, params object[] args)
        {
            _lines.Add(string.Format("[ERROR]:<color=#ff0000>  {0}</color>", string.Format(message, args)));
            LimitLogCount();
        }

        public void Assert(bool condition, string message)
        {

        }

        public void Assert(bool condition, string message, params object[] args)
        {

        }

        public void Quit()
        {
            
        }

        #endregion

        public int _maxLogs = 1000;


        protected readonly List<string> _lines = new List<string>();
        protected Vector2 _scrollPosition;
        protected bool _visible;
        const string WindowTitle = "Console";
        readonly Rect _titleBarRect = new Rect(0, 0, 1000, 40);
        Rect _windowRect = new Rect(20, 20, Screen.width - (20 * 2), Screen.height - (20 * 2));

        void OnGUI()
        {
            if (GUI.Button(new Rect(5, 5, 60, 40), "Console"))
                _visible = !_visible;

            if (_visible)
            {
                _windowRect = GUILayout.Window(123456, _windowRect, DrawConsoleWindow, WindowTitle);
            }

            Color c = GUI.color;
        }

        public void DrawConsoleWindow(int windowId)
        {

            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition);
            int length = _lines.Count;
            for (var i = 0; i < length; i++)
                GUILayout.Label(_lines[i]);

            GUILayout.EndScrollView();
            GUI.contentColor = Color.white;
            //
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("清除"))
                _lines.Clear();
            GUILayout.EndHorizontal();
            // 拖拽活动区域
            GUI.DragWindow(_titleBarRect);
        }

        public void LimitLogCount()
        {
            int amountToRemove = Mathf.Max(_lines.Count - _maxLogs, 0);

            if (amountToRemove == 0)
                return;
            _lines.RemoveRange(0, amountToRemove);
        }
    }
}

