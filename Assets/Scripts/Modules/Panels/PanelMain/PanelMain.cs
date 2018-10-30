
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

        #endregion

        #region MONO Override

        void Awake()
        {
            _init();
        }

        void OnDisable()
        {
            EventBus.UnRegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);
        }

        void OnEnable()
        {
            EventBus.RegisterHandler(PanelConst.SELECT_TRACKLINE, OnSelectTrackLine);
        }

        #endregion

        #region Public

        public void AddTrackLine()
        {
            TrackLineItem item = Instantiate(_trackLinePfb);
            GameObjectHelper.SetParent(item.gameObject, _trackLinesParent);
            _trackItems.Add(item);
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
            AddTrackLine();
        }

        public void OnClickSave(GameObject go)
        {

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

