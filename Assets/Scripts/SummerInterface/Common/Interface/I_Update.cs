﻿

namespace Summer
{
    public interface I_Update
    {
        //int Priority { get; set; }
        void OnUpdate(float dt);
    }

    public interface I_RegisterHandler
    {
        void OnRegisterHandler();

        void UnRegisterHandler();
    }
}

