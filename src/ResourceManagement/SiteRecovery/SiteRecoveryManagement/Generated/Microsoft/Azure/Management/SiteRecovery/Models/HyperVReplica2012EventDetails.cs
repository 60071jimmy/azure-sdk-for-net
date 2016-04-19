// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Model class for event details of a HyperVReplica 2012 E2E event.
    /// </summary>
    public partial class HyperVReplica2012EventDetails : EventProviderSpecificDetails
    {
        private string _containerName;
        
        /// <summary>
        /// Optional. The container friendly name.
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }
        
        private string _fabricName;
        
        /// <summary>
        /// Optional. The fabric friendly name.
        /// </summary>
        public string FabricName
        {
            get { return this._fabricName; }
            set { this._fabricName = value; }
        }
        
        private string _remoteContainerName;
        
        /// <summary>
        /// Optional. The remote container name.
        /// </summary>
        public string RemoteContainerName
        {
            get { return this._remoteContainerName; }
            set { this._remoteContainerName = value; }
        }
        
        private string _remoteFabricName;
        
        /// <summary>
        /// Optional. The remote fabric name.
        /// </summary>
        public string RemoteFabricName
        {
            get { return this._remoteFabricName; }
            set { this._remoteFabricName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HyperVReplica2012EventDetails
        /// class.
        /// </summary>
        public HyperVReplica2012EventDetails()
        {
        }
    }
}