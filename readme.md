# BungieNetApi
This is a class library wich contains a simple wrapper for the [Bungie.Net](https://github.com/Bungie-net/api) API targeting .Net 5.

# Current support:
- 🟢 Supported API 
- 🔴 Unsupported API 
- 🟠 Incomplete implementation 
- 🟡 Bungie marked this API as "preview" 
## App
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | App.GetApplicationApiUsage | 🔴 |
| GET | App.GetApplicationApiUsage | 🔴 |

## User
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | User.GetBungieNetUserById | 🔴 |
| GET | User.SearchUsers | 🔴 |
| GET | User.GetCredentialTypesForTargetAccount | 🔴 |
| GET | User.GetAvaiableThemes | 🔴 |
| GET | User.GetMembershipDataById | 🔴 |
| GET | User.GetMembershipDataForCurrentUser | 🔴 |
| GET | User.GetMembershipFromHardLinkedCredential | 🔴 |

## Content
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | Content.GetContentType | 🔴 |
| GET | Content.GetContentById | 🔴 |
| GET | Content.GetContentByTagAndType | 🔴 |
| GET | Content.SearchContentWithText | 🔴 |
| GET | Content.SearchContentByTagAndType | 🔴 |
| GET | Content.SearchHelpArticles | 🔴 |

## Forum
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | Forum.GetTopicsPaged | 🔴 |
| GET | Forum.GetCoreTopicsPaged | 🔴 |
| GET | Forum.GetPostsThreadedPaged | 🔴 |
| GET | Forum.GetPostsThreadedPagedFromChild | 🔴 |
| GET | Forum.GetPostAndParent | 🔴 |
| GET | Forum.GetPostAndParentAwaitingApproval | 🔴 |
| GET | Forum.GetTopicForContent | 🔴 |
| GET | Forum.GetForumTagSuggestions | 🔴 |
| GET | Forum.GetPoll | 🔴 |
| POST | Forum.GetRecruitmentThreadSummaries | 🔴 |

## GroupV2
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | GroupV2.GetAvailableAvatars | 🔴 |
| GET | GroupV2.GetAvailableThemes | 🔴 |
| GET | GroupV2.GetUserClanInviteSetting | 🔴 |
| POST | GroupV2.GetRecommendedGroups | 🔴 |
| POST | GroupV2.GroupSearch | 🔴 |
| GET | GroupV2.GetGroup | 🔴 |
| GET | GroupV2.GetGroupByName | 🔴 |
| POST | GroupV2.GetGroupByNameV2 | 🔴 |
| GET | GroupV2.GetGroupOptionalConversations | 🔴 |
| POST | GroupV2.EditGroup | 🔴 |
| POST | GroupV2.EditClanBanner | 🔴 |
| POST | GroupV2.EditFounderOptions | 🔴 |
| POST | GroupV2.AddOptionalConversation | 🔴 |
| POST | GroupV2.EditOptionalConversation | 🔴 |
| GET | GroupV2.GetMembersOfGroup | 🔴 |
| GET | GroupV2.GetAdminsAndFounderOfGroup | 🔴 |
| POST | GroupV2.EditGroupMembership | 🔴 |
| POST | GroupV2.KickMember | 🔴 |
| POST | GroupV2.BanMember | 🔴 |
| POST | GroupV2.UnbanMember | 🔴 |
| GET | GroupV2.GetBannedMembersOfGroup | 🔴 |
| POST | GroupV2.AbdicateFoundership | 🔴 |
| GET | GroupV2.GetPendingMemberships | 🔴 |
| GET | GroupV2.GetInvitedIndividuals | 🔴 |
| POST | GroupV2.ApproveAllPending | 🔴 |
| POST | GroupV2.DenyAllPending | 🔴 |
| POST | GroupV2.ApprovePendingForList | 🔴 |
| POST | GroupV2.ApprovePending | 🔴 |
| POST | GroupV2.DenyPendingForList | 🔴 |
| GET | GroupV2.GetGroupsForMember | 🔴 |
| GET | GroupV2.RecoverGroupForFounder | 🔴 |
| GET | GroupV2.GetPotentialGroupsForMember | 🔴 |
| POST | GroupV2.IndividualGroupInvite | 🔴 |
| POST | GroupV2.IndividualGroupInviteCancel | 🔴 |

## Tokens
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| POST | Tokens.ClaimPartnerOffer | 🔴 |
| POST | Tokens.ApplyMissingPartnerOffersWithoutClaim | 🔴 |
| GET | Tokens.GetPartnerOfferSkuHistory | 🔴 |

## Destiny2
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | Destiny2.GetDestinyManifest | 🟢 |
| GET | Destiny2.GetDestinyEntityDefinition | 🟢 |
| GET | Destiny2.SearchDestinyPlayer | 🟢 |
| GET | Destiny2.GetLinkedProfiles | 🟢 |
| GET | Destiny2.GetProfile | 🟠 |
| GET | Destiny2.GetCharacter | 🔴 |
| GET | Destiny2.GetClanWeeklyRewardState | 🔴 |
| GET | Destiny2.GetItem | 🔴 |
| GET | Destiny2.GetVendors | 🔴 |
| GET | Destiny2.GetVendor | 🔴 |
| GET | Destiny2.GetPublicVendors | 🔴🟡 |
| GET | Destiny2.GetCollectibleNodeDetails | 🔴 |
| POST | Destiny2.TransferItem | 🔴 |
| POST | Destiny2.PullFromPostmaster | 🔴 |
| POST | Destiny2.EquipItem | 🔴 |
| POST | Destiny2.EquipItems | 🔴 |
| POST | Destiny2.SetItemLockState | 🔴 |
| POST | Destiny2.SetQuestTrackedState | 🔴 |
| POST | Destiny2.InsertSocketPlug | 🔴🟡 |
| GET | Destiny2.GetPostGameCarnageReport | 🔴 |
| POST | Destiny2.ReportOffensivePostGameCarnageReportPlayer | 🔴 |
| GET | Destiny2.GetHistoricalStatsDefinition | 🔴 |
| GET | Destiny2.GetClanLeaderboards | 🔴🟡 |
| GET | Destiny2.GetClanAggregateStats | 🔴🟡 |
| GET | Destiny2.GetLeaderboards | 🔴🟡 |
| GET | Destiny2.GetLeaderboardsForCharacter | 🔴🟡 |
| GET | Destiny2.SearchDestinyEntities | 🔴 |
| GET | Destiny2.GetHistoricalStats | 🔴 |
| GET | Destiny2.GetHistoricalStatsForAccount | 🔴 |
| GET | Destiny2.GetActivityHistory | 🔴 |
| GET | Destiny2.GetUniqueWeaponHistory | 🔴 |
| GET | Destiny2.GetDestinyAggregateActivityStats | 🔴 |
| GET | Destiny2.GetPublicMilestoneContent | 🔴 |
| GET | Destiny2.GetPublicMilestones | 🔴 |
| POST | Destiny2.AwaInitializeRequest | 🔴 |
| POST | Destiny2.AwaProvideAuthorizationResult | 🔴 |
| GET | Destiny2.AwaGetActionToken | 🔴 |

## CommunityContent
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | CommunityContent.GetCommunityContent | 🔴 |

## Trending
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | Trending.GetTrendingCategories | 🔴 |
| GET | Trending.GetTrendingCategory | 🔴 |
| GET | Trending.GetTrendingEntryDetail | 🔴 |

## Fireteam
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | Fireteam.GetActivePrivateClanFireteamCount | 🔴 |
| GET | Fireteam.GetAvailableClanFireteams | 🔴 |
| GET | Fireteam.SearchPublicAvailableClanFireteams | 🔴 |
| GET | Fireteam.GetMyClanFireteams | 🔴 |
| GET | Fireteam.GetClanFireteam | 🔴 |

## Misc
| Http Method | Api | Supported |
| ----------- | --- | --------- |
| GET | .GetAvailableLocales | 🔴 |
| GET | .GetCommonSettings | 🔴 |
| GET | .GetUserSystemOverrides | 🔴 |
| GET | .GetGlobalAlerts | 🔴 |