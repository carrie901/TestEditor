
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


using UnityEngine;
using UnityEngine.UI;

public class PlayAnimItem : SeqNodeItem
{

    #region 属性

    public Text _des;
    public InputField _animField;
    public PlayAnimInfo _info;

    #endregion

    #region MONO Override

    // Use this for initialization
    void Start()
    {

    }

    void OnDisable()
    {
        _animField.onValueChanged.RemoveListener(OnValueChanged);
    }

    void OnEnable()
    {
        _animField.onValueChanged.AddListener(OnValueChanged);
    }

    #endregion

    #region Public



    #endregion

    public void OnValueChanged(string param)
    {
        _info.AnimName = param.Trim();
    }

    #region Private Methods



    #endregion

    public override void Add(TrackLineInfo info)
    {
        _info = new PlayAnimInfo();
        info.AddNode(_info);
    }

    public override SeqNodeInfo Get()
    {
        return _info;
    }
}
