
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

namespace Summer.SkillEditor
{

    public class TimeLines : MonoBehaviour
    {

        #region 属性

        public TimeLabel[] _times;

        #endregion

        #region MONO Override

        // Use this for initialization
        void Start()
        {
            _times = gameObject.GetComponentsInChildren<TimeLabel>();
            int length = _times.Length;
            for (int i = 0; i < length; i++)
            {
                _times[i].SetTime(i + 1);
            }
        }

        #endregion

        #region Public



        #endregion

        #region Private Methods



        #endregion
    }
}

