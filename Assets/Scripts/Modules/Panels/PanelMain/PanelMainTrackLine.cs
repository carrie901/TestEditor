
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

public class PanelMainTrackLine : MonoBehaviour
{

    #region 属性

    public GameObject _nodesParent;
    public List<SeqNodeItem> _items;
    public TrackLineInfo _info;
    #endregion

    #region MONO Override

    void Awake()
    {

    }

    void OnDisable()
    {
        EventBus.UnRegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);//SkillPfbPath
    }

    void OnEnable()
    {
        EventBus.RegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);//SkillPfbPath
    }

    #endregion

    #region Public


    public void OnSelectTrackLine(System.Object info)
    {
        _info = info as TrackLineInfo;
        for (int i = 0; i < _items.Count; i++)
        {
            Destroy(_items[i].gameObject);
            _items[i] = null;
        }
        _items.Clear();



    }

    #endregion

    #region Private Methods

    public void InitNode(EdNode node)
    {

    }

    #endregion
}
