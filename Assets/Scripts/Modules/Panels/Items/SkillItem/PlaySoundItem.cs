
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
using UnityEngine.UI;

public class PlaySoundItem : SeqNodeItem
{

    #region 属性

    public Text _des;
    public InputField _field;
    public PlaySoundInfo _info;

    #endregion

    #region MONO Override

    void OnDisable()
    {
        _field.onValueChanged.RemoveListener(OnValueChanged);
    }

    void OnEnable()
    {
        _field.onValueChanged.AddListener(OnValueChanged);
    }

    #endregion

    #region Public



    #endregion

    #region Override

    public override void Add(TrackLineInfo info)
    {
        _info = new PlaySoundInfo();
        info.AddNode(_info);
    }

    public override SeqNodeInfo Get()
    {
        return _info;
    }

    #endregion

    #region Private Methods

    private void OnValueChanged(string param)
    {
        _info.SoundName = param.Trim();
    }

    #endregion


}
