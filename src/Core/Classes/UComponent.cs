﻿using UELib.Annotations;
using UELib.Branch;

namespace UELib.Core
{
    [UnrealRegisterClass]
    [BuildGeneration(BuildGeneration.UE3)]
    public class UComponent : UObject
    {
        [CanBeNull] public UClass TemplateOwnerClass;
        public UName TemplateName;
        
        public UComponent()
        {
            ShouldDeserializeOnDemand = true;
        }
    }
}
