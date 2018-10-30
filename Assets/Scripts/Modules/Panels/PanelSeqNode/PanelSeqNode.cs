
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

using System;
using System.Collections.Generic;
using Summer;
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;
public class PanelSeqNode : MonoBehaviour
{

    #region

    
    #endregion

    #region 属性

    public GameObject _menuParent;
    public GameObject _desParent;
    public GameObject _menuPfb;
    public GameObject _desPfb;
    public Text _des;
    public GameObject _sureBtn;
    public GameObject _cancelBtn;
    public SeqNodeCnf _selectCnf;
    private List<SeqNodeDes> _nodes = new List<SeqNodeDes>();

    #endregion

    #region MONO Override
    void Awake()
    {
        Init();
    }

    void OnDisable()
    {
        EventBus.UnRegisterHandler(PanelConst.SELECT_MENU, OnSelectMenu);
        EventBus.UnRegisterHandler(PanelConst.SELECT_DES, OnSelectDes);
    }

    void OnEnable()
    {
        EventBus.RegisterHandler(PanelConst.SELECT_MENU, OnSelectMenu);
        EventBus.RegisterHandler(PanelConst.SELECT_DES, OnSelectDes);
    }

    #endregion

    #region Public

    public void SureClick(GameObject go)
    {
        EventBus.RaiseEvent(PanelConst.SURE_SELECT, _selectCnf);
        CancelClick(null);
    }

    public void CancelClick(GameObject go)
    {
        PanelManager.Instance.OpenMain();
    }
    #endregion

    #region Private Methods

    private void OnSelectMenu(System.Object param)
    {
        string menu = param as string;
        List<SeqNodeCnf> infos = SeqNodeProxy.Instance.GetDesByMenu(menu);
        int length = _nodes.Count;
        for (int i = 0; i < length; i++)
        {
            _nodes[i].gameObject.SetActive(false);
            _nodes[i].SetEmpty();
        }
        length = infos.Count;
        for (int i = 0; i < length; i++)
        {
            if (i < _nodes.Count)
            {
                _nodes[i].gameObject.SetActive(true);
                _nodes[i].Set(infos[i]);
            }
            else
            {
                GameObject go = Instantiate(_desPfb);
                SeqNodeDes des = go.GetComponent<SeqNodeDes>();
                des.Set(infos[i]);
                _nodes.Add(des);
                GameObjectHelper.SetParent(go, _desParent);
            }
        }
    }

    private void OnSelectDes(System.Object param)
    {
        _selectCnf = param as SeqNodeCnf;
        if (_selectCnf == null)
        {
            _des.text = String.Empty;
        }
        else
        {
            _des.text = _selectCnf.Des;
        }
    }

    private void Init()
    {
        Dictionary<string, List<SeqNodeCnf>> infos = SeqNodeProxy.Instance.GetNodes();
        foreach (var info in infos)
        {
            GameObject go = Instantiate(_menuPfb);
            SeqNodeMenu menu = go.GetComponent<SeqNodeMenu>();
            menu.Set(info.Key);
            GameObjectHelper.SetParent(go, _menuParent);
        }
        UIEventListener.Get(_cancelBtn).OnClick = CancelClick;
        UIEventListener.Get(_sureBtn).OnClick = SureClick;
    }

    #endregion
}
