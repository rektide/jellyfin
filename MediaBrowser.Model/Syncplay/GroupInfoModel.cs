namespace MediaBrowser.Model.Syncplay
{
    /// <summary>
    /// Class GroupInfoModel.
    /// </summary>
    public class GroupInfoView
    {
        /// <summary>
        /// Gets or sets the group identifier.
        /// </summary>
        /// <value>The group identifier.</value>
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the playing item id.
        /// </summary>
        /// <value>The playing item id.</value>
        public string PlayingItemId { get; set; }

        /// <summary>
        /// Gets or sets the playing item name.
        /// </summary>
        /// <value>The playing item name.</value>
        public string PlayingItemName { get; set; }

        /// <summary>
        /// Gets or sets the position ticks.
        /// </summary>
        /// <value>The position ticks.</value>
        public long PositionTicks { get; set; }

        /// <summary>
        /// Gets or sets the partecipants.
        /// </summary>
        /// <value>The partecipants.</value>
        public string[] Partecipants { get; set; }
    }
}
