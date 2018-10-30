
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

/// <summary>
/// 
/// </summary>
public class TrackLineInfo
{
    public int _sFrame;                                        // 开始的帧数 以0作为起点
    public int _eFrame;                                        // 
    public string _des = "描述信息";
    public List<SeqNodeInfo> _nodes = new List<SeqNodeInfo>();

    public TrackLineInfo()
    {
        _sFrame = 0;
        _eFrame = 1;
    }

    public void AddNode(SeqNodeInfo info)
    {
        _nodes.Add(info);
    }

    public virtual string ToDes()
    {
        return string.Empty;
    }
}
public class SeqNodeInfo
{
    public virtual string ToDes()
    {
        return string.Empty;
    }
}

public class PlayAnimInfo : SeqNodeInfo
{
    public string AnimName;
}

[Serializable]
public class PlayEffectInfo : SeqNodeInfo
{
    public string EffName;
}

[Serializable]
public class PlaySoundInfo : SeqNodeInfo
{
    public string SoundName;
}
