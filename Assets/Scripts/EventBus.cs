
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
using Object = System.Object;

public class EventBus
{
    private static EventBus Instance = new EventBus();

    private readonly EventSet<string, System.Object> _eventSet = new EventSet<string, System.Object>(128);
    protected EventBus() { }

    public static bool RegisterHandler(string key, EventSet<string, System.Object>.EventHandler handler)
    {
        return Instance._eventSet.RegisterHandler(key, handler);
    }

    public static bool UnRegisterHandler(string key, EventSet<string, System.Object>.EventHandler handler)
    {
        return Instance._eventSet.UnRegisterHandler(key, handler);
    }

    public static bool RaiseEvent(string key, System.Object param = null, bool bDelay = false)
    {
        return Instance._eventSet.RaiseEvent(key, param, bDelay);
    }
}
