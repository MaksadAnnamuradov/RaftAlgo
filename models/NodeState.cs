 /// <summary>
    /// Possible states a node can be in
    /// </summary>
    public enum NodeState {
        /// <summary>
        /// Represents the node is in leader state, as defined by the Raft specification
        /// </summary>
        Leader,
        /// <summary>
        /// Represents the node is in follower state, as defined by the Raft specification
        /// </summary>
        Follower,
        /// <summary>
        /// Represents the node is in candidate state, as defined by the Raft specification
        /// </summary>
        Candidate,
        /// <summary>
        /// Represents the node has been stopped (see <see cref="RaftNode.Stop"/> and won't respond to RPCs.
        /// </summary>
        Stopped
    };