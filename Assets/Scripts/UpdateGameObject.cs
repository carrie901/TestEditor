﻿
//
//                            _ooOoo_
//                           o8888888o
//                           88" . "88
//                           (| -_- |)
//                           O\  =  /O
//                        ____/`---'\____
//                      .'  \\|     |//  `.
//                     /  \\|||  :  |||//  \
//                    /  _||||| -:- |||||-  \
//                    |   | \\\  -  /// |   |
//                    | \_|  ''\---/''  |   |
//                    \  .-\__  `-`  ___/-. /
//                  ___`. .'  /--.--\  `. . __
//               ."" '<  `.___\_<|>_/___.'  >'"".
//              | | :  `- \`.;`\ _ /`;.`/ - ` : | |
//              \  \ `-.   \_ __\ /__ _/   .-` /  /
//         ======`-.____`-.___\_____/___.-`____.-'======
//                            `=---='
//        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
//                 			 佛祖 保佑             

using System.Collections.Generic;
using UnityEngine;

namespace Summer.Skill
{
    public class UpdateGameObject : MonoBehaviour
    {

        [RuntimeInitializeOnLoadMethod]
        public static void OnStart()
        {
            Resources.UnloadUnusedAssets();
            // 所有需要调用OnUpdate(dt)方法的入口
            Debug.Log("---------------------必须项-->初始化UpdateGameObject-------------------");
            ConfigManager.Init();
        }

        #region 属性



        #endregion

        #region MONO Override

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region Public



        #endregion

        #region Private Methods



        #endregion
    }
}
