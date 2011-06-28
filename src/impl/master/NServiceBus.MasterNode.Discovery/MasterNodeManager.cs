﻿namespace NServiceBus.MasterNode.Discovery
{
    public class MasterNodeManager : IManageTheMasterNode
    {
        Address IManageTheMasterNode.GetMasterNode()
        {
            if (IsCurrentNodeTheMaster)
                return Address.Local;

            return MasterNode;
        }

        public bool IsCurrentNodeTheMaster { get; set; }
        public Address MasterNode { get; set; }

    }
}
