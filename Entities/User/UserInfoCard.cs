using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.User
{

    public struct UserInfoCard
    {
        [JsonPropertyName("supplementalDisplayName")]
        public string SupplementalDisplayName { get; set; }

        [JsonPropertyName("iconPath")]
        public string IconPath { get; set; }

        [JsonPropertyName("crossSaveOverride")]
        public int CrossSaveOverride { get; set; }

        [JsonPropertyName("applicableMembershipTypes")]
        public int[] ApplicableMembershipTypes { get; set; }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("membershipType")]
        public int MembershipType { get; set; }

        [JsonPropertyName("membershipId")]
        public long MembershipId { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    }
}