﻿using System;

namespace EncoreTickets.SDK
{
    public class ApiContext
    {
        #region Properties

        /// <summary>
        /// The environment
        /// </summary>
        public string envrionment { get; set; }

        /// <summary>
        /// Use broadway 
        /// </summary>
        public bool useBroadway { get; set; }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        /// <value>The password.</value>
        public string password { get; protected set; }

        /// <summary>
        /// Gets or sets the Nova user name of the user that your API calls will run as.
        /// </summary>
        /// <value>The name of the user.</value>
        public string userName { get; protected set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string accessToken { get; set; }

        /// <summary>
        /// Gets or sets the timeout milliseconds.
        /// </summary>
        /// <value>The timeout milliseconds.</value>
        public int timeoutMilliseconds { get; set; }

        /// <summary>
        /// The affiliate
        /// </summary>
        public string affiliate { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when an error occurred.
        /// </summary>
        public static event EventHandler<ApiErrorEventArgs> ApiError;

        #endregion // Events

        #region Constructors

        /// <summary>
        /// Initializes static members of the <see cref="ApiContext"/> class.
        /// </summary>
        public ApiContext(Environments env, string userName, string password)
            : this(env)
        {
            this.userName = userName;
            this.password = password;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ApiContext()
            : this(Environments.Production)
        { 
            timeoutMilliseconds = 120000;
        }

        /// <summary>
        /// Initializes static members of the <see cref="ApiContext"/> class.
        /// </summary>
        public ApiContext(Environments env)
        {
            envrionment = (env == Environments.Production) ? "" : "dev";
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Called when an error occurred.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ApiErrorEventArgs"/> instance containing the event data.</param>
        /// <returns>if handled</returns>
        public static bool OnErrorOccurred(object sender, ApiErrorEventArgs e)
        {
            if (ApiError != null)
            {
                ApiError(sender, e);
                return true;
            }
            return false;
        }

        #endregion
    }
}
