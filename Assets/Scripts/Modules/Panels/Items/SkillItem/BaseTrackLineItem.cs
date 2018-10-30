
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

using Summer;
using UnityEngine;
using UnityEngine.UI;

public class BaseTrackLineItem : MonoBehaviour
{

    #region 属性

    public Text _trackLineName;
    public InputField _desField;
    public InputField _startFrame;
    public InputField _endFrame;

    private TrackLineInfo _info;

    #endregion

    #region MONO Override

    void OnDisable()
    {
        _startFrame.onValueChanged.RemoveListener(OnStartValueChange);
        _endFrame.onValueChanged.RemoveListener(OnEndValueChange);
        _desField.onValueChanged.RemoveListener(OnDesValueChange);
    }

    void OnEnable()
    {
        _startFrame.onValueChanged.AddListener(OnStartValueChange);
        _endFrame.onValueChanged.AddListener(OnEndValueChange);
        _desField.onValueChanged.AddListener(OnDesValueChange);
    }


    #endregion

    #region Public

    public void Set(TrackLineInfo info)
    {
        gameObject.SetActive(true);
        _info = info;
        _startFrame.text = info._sFrame.ToString();
        _endFrame.text = info._eFrame.ToString();
        _desField.text = info._des;
    }

    #endregion

    #region Private Methods

    private void OnStartValueChange(string param)
    {
        LogManager.Assert(_info != null, "BaseTrackLineItem OnStartValueChange Info Is Null");
        int frame = int.Parse(param);
        _info._sFrame = frame;
    }
    private void OnEndValueChange(string param)
    {
        LogManager.Assert(_info != null, "BaseTrackLineItem OnEndValueChange Info Is Null");
        int frame = int.Parse(param);
        _info._eFrame = frame;
    }

    private void OnDesValueChange(string param)
    {
        LogManager.Assert(_info != null, "BaseTrackLineItem OnDesValueChange Info Is Null");
        _info._des = param;
    }

    #endregion


}
