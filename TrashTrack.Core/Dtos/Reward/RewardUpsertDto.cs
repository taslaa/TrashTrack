﻿namespace TrashTrack.Core
{
    public class RewardUpsertDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PointValue { get; set; }
    }
}