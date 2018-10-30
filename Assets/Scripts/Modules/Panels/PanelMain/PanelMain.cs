
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

namespace Summer
{
    public class PanelMain : MonoBehaviour
    {

        #region 属性

        public GameObject _saveSkillBtn;                            // 保存当前技能
        public GameObject _addSeqBtn;                               // 增加时间线中的节点
        public GameObject _addTrackBtn;                             // 增加时间线Tackline
        public GameObject _trackLinesParent;                        // TackLine的父类
        public TrackLineItem _trackLinePfb;                         // TrackLine的预设

        public List<TrackLineItem> _trackItems;
        public SequenceInfo _info;
        #endregion

        #region MONO Override

        void Awake()
        {
            _init();
            _info = new SequenceInfo();
        }

        void OnDisable()
        {
            EventBus.UnRegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);
            EventBus.UnRegisterHandler(PanelConst.ADD_TRACKLINE, OnAddTrickLine);
        }

        void OnEnable()
        {
            EventBus.RegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);
            EventBus.RegisterHandler(PanelConst.ADD_TRACKLINE, OnAddTrickLine);
        }

        #endregion

        #region Public

        public void AddTrackLine()
        {

        }

        public void RemoveTrackLine(TrackLineItem item)
        {
            _trackItems.Remove(item);
            Destroy(item.gameObject);
        }

        public void AddLeafNode()
        {

        }

        public void RemoevLeafNode()
        {

        }

        #region 按钮响应

        public void OnClickAddTrack(GameObject go)
        {
            EventBus.RaiseEvent(PanelConst.ADD_TRACKLINE, new TrackLineInfo());
        }

        public void OnClickSave(GameObject go)
        {
            SequenceProxy.Instance.Save(_info);
        }

        public void OnAddSeq(GameObject go)
        {
            PanelManager.Instance.OpenSeq();
        }

        #endregion

        #region 消息响应

        public void OnSelectTrackLine(System.Object obj)
        {

        }

        public void OnAddTrickLine(System.Object obj)
        {
            TrackLineInfo info = obj as TrackLineInfo;
            TrackLineItem item = Instantiate(_trackLinePfb);
            item.Set(info);
            GameObjectHelper.SetParent(item.gameObject, _trackLinesParent);
            _trackItems.Add(item);
            _info.AddTrackLine(info);
        }

        #endregion

        #endregion

        #region Private Methods

        private void _init()
        {
            UIEventListener.Get(_addTrackBtn).OnClick = OnClickAddTrack;
            UIEventListener.Get(_saveSkillBtn).OnClick = OnClickSave;
            UIEventListener.Get(_addSeqBtn).OnClick = OnAddSeq;
        }

        #endregion
    }

}

