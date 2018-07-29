
namespace Wykop.Models
{
    using System;
    using Newtonsoft.Json;

    public partial class WykopTagResult
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }

        [JsonProperty("comment_count")]
        public long CommentCount { get; set; }

        [JsonProperty("report_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportCount { get; set; }

        [JsonProperty("related_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RelatedCount { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_group")]
        public long AuthorGroup { get; set; }

        [JsonProperty("author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty("author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty("author_avatar_med")]
        public string AuthorAvatarMed { get; set; }

        [JsonProperty("author_avatar_lo")]
        public string AuthorAvatarLo { get; set; }

        [JsonProperty("author_sex")]
        public string AuthorSex { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("preview", NullValueHandling = NullValueHandling.Ignore)]
        public string Preview { get; set; }

        [JsonProperty("user_vote")]
        public bool UserVote { get; set; }

        [JsonProperty("user_favorite")]
        public bool UserFavorite { get; set; }

        [JsonProperty("user_observe", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserObserve { get; set; }

        [JsonProperty("user_lists", NullValueHandling = NullValueHandling.Ignore)]
        public object[] UserLists { get; set; }

        [JsonProperty("plus18", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Plus18 { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("can_vote", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanVote { get; set; }

        [JsonProperty("has_own_content", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasOwnContent { get; set; }

        [JsonProperty("is_hot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHot { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        [JsonProperty("violation_url")]
        public object ViolationUrl { get; set; }

        [JsonProperty("info")]
        public object Info { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("comments")]
        public Comment[] Comments { get; set; }

        [JsonProperty("commented", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Commented { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("receiver")]
        public object Receiver { get; set; }

        [JsonProperty("receiver_avatar")]
        public object ReceiverAvatar { get; set; }

        [JsonProperty("receiver_avatar_big")]
        public object ReceiverAvatarBig { get; set; }

        [JsonProperty("receiver_avatar_med")]
        public object ReceiverAvatarMed { get; set; }

        [JsonProperty("receiver_avatar_lo")]
        public object ReceiverAvatarLo { get; set; }

        [JsonProperty("receiver_group")]
        public object ReceiverGroup { get; set; }

        [JsonProperty("receiver_sex")]
        public object ReceiverSex { get; set; }

        [JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Blocked { get; set; }

        [JsonProperty("voters", NullValueHandling = NullValueHandling.Ignore)]
        public Voter[] Voters { get; set; }

        [JsonProperty("embed")]
        public Embed Embed { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("can_comment")]
        public object CanComment { get; set; }
    }

    public partial class Comment
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty("author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty("author_avatar_med")]
        public string AuthorAvatarMed { get; set; }

        [JsonProperty("author_avatar_lo")]
        public string AuthorAvatarLo { get; set; }

        [JsonProperty("author_group")]
        public long AuthorGroup { get; set; }

        [JsonProperty("author_sex")]
        public string AuthorSex { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("entry_id")]
        public long EntryId { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }

        [JsonProperty("user_vote")]
        public long UserVote { get; set; }

        [JsonProperty("voters")]
        public Voter[] Voters { get; set; }

        [JsonProperty("embed")]
        public Embed Embed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("violation_url")]
        public object ViolationUrl { get; set; }
    }

    public partial class Embed
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("plus18")]
        public bool Plus18 { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public partial class Voter
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_group")]
        public long AuthorGroup { get; set; }

        [JsonProperty("author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty("author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty("author_avatar_med")]
        public string AuthorAvatarMed { get; set; }

        [JsonProperty("author_avatar_lo")]
        public string AuthorAvatarLo { get; set; }

        [JsonProperty("author_sex")]
        public string AuthorSex { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("is_observed")]
        public bool IsObserved { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("counters")]
        public Counters Counters { get; set; }
    }

    public partial class Counters
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("entries")]
        public long Entries { get; set; }

        [JsonProperty("links")]
        public long Links { get; set; }
    }
}
