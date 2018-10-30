
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
using Summer;
using UnityEngine;
using UnityEngine.UI;

public class SeqNodeMenu : MonoBehaviour
{

    #region 属性

    public Text _menu;
    public GameObject _btn;
    #endregion

    void Start()
    {
        UIEventListener.Get(_btn).OnClick = OnClick;
    }

    #region Public

    public void Set(string menu)
    {
        _menu.text = menu;
    }

    public void OnClick(GameObject go)
    {
        EventBus.RaiseEvent(PanelSeqNode.SELECT_MENU, _menu.text);
    }

    #endregion

    #region Private Methods



    #endregion
}
