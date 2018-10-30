
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

public class SeqNodeProxy
{

    public static SeqNodeProxy Instance = new SeqNodeProxy();

    private readonly Dictionary<string, List<SeqNodeCnf>> _map = new Dictionary<string, List<SeqNodeCnf>>();
    private SeqNodeProxy()
    {
        Init();
    }


    public List<SeqNodeCnf> GetDesByMenu(string menu)
    {
        return _map[menu];
    }



    public Dictionary<string, List<SeqNodeCnf>> GetNodes() { return _map; }

    private void Init()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Config/01");
        List<string[]> info = StringHelper.ParseData(textAsset.text);

        _map.Clear();

        int length = info.Count;
        for (int i = 0; i < length; i++)
        {
            SeqNodeCnf cnf = new SeqNodeCnf();
            cnf.Set(info[i]);
            if (!_map.ContainsKey(cnf.Menu))
            {
                _map.Add(cnf.Menu, new List<SeqNodeCnf>());
            }
            _map[cnf.Menu].Add(cnf);

        }
    }
}
