
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
    public BaseTrackLineItem _baseFrameItem;
    public TrackLineInfo _info;

    #endregion

    #region MONO Override

    void OnDisable()
    {
        EventBus.UnRegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);//SkillPfbPath
        EventBus.UnRegisterHandler(PanelConst.SURE_SELECT, OnAddSeq);
        EventBus.UnRegisterHandler(PanelConst.ADD_TRACKLINE, OnAddTrickLine);
    }

    void OnEnable()
    {
        EventBus.RegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);//SkillPfbPath
        EventBus.RegisterHandler(PanelConst.SURE_SELECT, OnAddSeq);
        EventBus.RegisterHandler(PanelConst.ADD_TRACKLINE, OnAddTrickLine);
    }

    #endregion

    #region Public



    #endregion

    #region 消息响应

    public void OnSelectTrackLine(System.Object param)
    {
        _info = param as TrackLineInfo;
        Clear();
        _baseFrameItem.Set(_info);
    }

    public void OnAddSeq(System.Object param)
    {
        SeqNodeCnf info = param as SeqNodeCnf;
        GameObject go = Resources.Load<GameObject>("Prefab/UI/Skill/" + info.Pfb);
        GameObject insGo = Instantiate(go);
        SeqNodeItem item = insGo.GetComponent<SeqNodeItem>();
        item.Add(_info);
        GameObjectHelper.SetParent(insGo, _nodesParent);
    }

    private void OnAddTrickLine(System.Object param)
    {
        OnSelectTrackLine(param);
    }

    #endregion

    #region Private Methods

    private void Clear()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            Destroy(_items[i].gameObject);
            _items[i] = null;
        }
        _items.Clear();
    }

    #endregion
}
