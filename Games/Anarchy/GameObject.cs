// Generated by Creer at 10:46PM on October 16, 2015 UTC, git hash: '98604e3773d1933864742cb78acbf6ea0b4ecd7b'
// An object in the game. The most basic class that all game classes should inherit from automatically.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Anarchy
{
    /// <summary>
    /// An object in the game. The most basic class that all game classes should inherit from automatically.
    /// </summary>
    class GameObject : BaseGameObject
    {
        #region Properties
        /// <summary>
        /// String representing the top level Class that this game object is an instance of. Used for reflection to create new instances on clients, but exposed for convenience should AIs want this data.
        /// </summary>
        public string GameObjectName { get; protected set; }

        /// <summary>
        /// Any strings logged will be stored here when this game object logs the strings. Intended for debugging.
        /// </summary>
        public IList<string> Logs { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of {$obj_key}. Used during game initialization, do not call directly.
        /// </summary>
        protected GameObject() : base()
        {
            this.Logs = new List<string>();
        }

        /// <summary>
        /// adds a message to this game object's log. Intended for debugging purposes.
        /// </summary>
        /// <param name="message">A string to add to this GameObject's log. Intended for debugging.</param>
        public void Log(string message)
        {
            this.RunOnServer<object>("log", new Dictionary<string, object> {
                {"message", message}
            });
        }

        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
