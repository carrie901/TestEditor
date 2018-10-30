﻿using UnityEngine;

namespace Summer
{
    /// <summary>
    /// 对Time的一层包装
    /// 想做统一化处理
    /// </summary>
    public class TimeManager
    {
        public static float DeltaTime
        {
            get { return Time.deltaTime; }
        }

        public static float TimeScale
        {
            get { return Time.timeScale; }
            set { Time.timeScale = value; }
        }

        public static float RealtimeSinceStartup
        {
            get { return Time.realtimeSinceStartup; }
        }

        /// <summary>
        /// 当前帧数
        /// </summary>
        public static int FrameCount { get { return Time.frameCount; } }


        public static float _last_time;
        public static void BeginSampleTime()
        {
            _last_time = Time.realtimeSinceStartup;
        }

        public static float EndSimpleTime()
        {
            float dt = Time.realtimeSinceStartup - _last_time;
            return dt;
        }

        public static void InputSimpleTime()
        {
            float e = EndSimpleTime();
            Debug.Log(e);
        }
    }
}
