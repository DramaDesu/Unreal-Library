﻿using System;

namespace UELib
{
    /// <summary>
    /// TODO: Re-purpose.
    /// <seealso cref="Branch.EngineBranch"/>
    /// </summary>
    public enum BuildGeneration
    {
        Undefined,

        /// <summary>
        /// Unreal Engine 1
        ///
        /// Not in use yet.
        /// </summary>
        UE1,

        /// <summary>
        /// Modified version for Harry Potter's Unreal Engine 1
        /// </summary>
        HP,

        /// <summary>
        /// Unreal Engine 2
        /// 
        /// Not in use yet.
        /// </summary>
        UE2,

        /// <summary>
        /// Heavily modified Unreal Engine 2 by Ion Storm for Thief: Deadly Shadows
        /// </summary>
        Flesh,

        /// <summary>
        /// Unreal Engine 2 with some early UE3 upgrades.
        /// </summary>
        UE2_5,

        /// <summary>
        /// The Unreal Engine 2.5 engine used in the America's Army series.
        /// </summary>
        AGP,

        /// <summary>
        /// Heavily modified Unreal Engine 2.5 for Vengeance: Tribes; also used by Swat4 and BioShock.
        /// </summary>
        Vengeance,

        /// <summary>
        /// Heavily modified Unreal Engine 2.5 for Splinter Cell
        ///
        /// Not yet supported.
        /// </summary>
        Lead,

        /// <summary>
        /// Modified Unreal Engine 2 for Xbox e.g. Unreal Championship 2: The Liandri Conflict
        /// </summary>
        UE2X,

        /// <summary>
        /// Unreal Engine 3
        ///
        /// Not in use yet.
        /// </summary>
        UE3,

        /// <summary>
        /// Rocksteady Studios
        ///
        /// Heavily modified Unreal Engine 3 for the Arkham series
        /// </summary>
        RSS,

        /// <summary>
        /// High Moon Studios
        ///
        /// Heavily modified Unreal Engine 3 for Transformers and Deadpool etc
        /// </summary>
        HMS,

        /// <summary>
        /// Gearbox Software
        ///
        /// Modified Unreal Engine 3 for Borderlands
        /// </summary>
        GB,

        /// <summary>
        /// Unreal Engine 4
        /// 
        /// Not in use yet.
        /// </summary>
        UE4
    }

    [Flags]
    [Obsolete("To be deprecated, see BuildPlatform")]
    public enum BuildFlags : byte
    {
        /// <summary>
        /// Is cooked for consoles.
        /// </summary>
        ConsoleCooked = 0x01,

        /// <summary>
        /// Is cooked for Xenon(Xbox 360). Could be true on PC games.
        /// </summary>
        XenonCooked = 0x02,
    }

    public enum BuildPlatform
    {
        Undetermined,
        PC,
        Console
    }

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class OverridePackageVersionAttribute : Attribute
    {
        public readonly uint FixedVersion;
        public readonly ushort? FixedLicenseeVersion;
        
        public OverridePackageVersionAttribute(uint fixedVersion)
        {
            FixedVersion = fixedVersion;
        }
        
        public OverridePackageVersionAttribute(uint fixedVersion, ushort fixedLicenseeVersion)
        {
            FixedVersion = fixedVersion;
            FixedLicenseeVersion = fixedLicenseeVersion;
        }
    }
}
