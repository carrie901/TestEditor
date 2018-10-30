
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

public class SeqNodeDes : MonoBehaviour
{

    #region 属性

    public Text _des;
    public SeqNodeCnf _cnf;
    public GameObject _btn;
    #endregion

    #region MONO Override

    // Use this for initialization
    void Start()
    {
        UIEventListener.Get(_btn).OnClick = OnClick;
    }

    #endregion

    #region Public

    public void Set(SeqNodeCnf cnf)
    {
        _cnf = cnf;
        _des.text = _cnf.Title;
    }

    public void SetEmpty()
    {
        _cnf = null;
        _des.text = string.Empty;
    }

    public void OnClick(GameObject go)
    {
        Debug.AssertFormat(_cnf != null, "选中的Des为空:[{0}]", gameObject.name);
        EventBus.RaiseEvent(PanelSeqNode.SELECT_DES, _cnf);
    }

    #endregion

    #region Private Methods



    #endregion
}
