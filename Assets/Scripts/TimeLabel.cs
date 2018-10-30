
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
using UnityEngine.UI;
public class TimeLabel : MonoBehaviour
{

    #region 属性

    public RectTransform _img;
    public int _frame;
    public Text _timeLab;
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

    public void SetTime(int frame)
    {
        _frame = frame;
        bool result = (frame % 10 == 0);
        _timeLab.text = frame.ToString();
        _timeLab.gameObject.SetActive(result);

        _img.sizeDelta = result ? new Vector2(3f, 500f) : new Vector2(3f, 15f);
    }

    #endregion

    #region Private Methods



    #endregion
}
