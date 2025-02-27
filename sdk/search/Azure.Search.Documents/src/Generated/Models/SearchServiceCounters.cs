// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents service-level resource counters and quotas. </summary>
    public partial class SearchServiceCounters
    {
        /// <summary> Initializes a new instance of <see cref="SearchServiceCounters"/>. </summary>
        /// <param name="aliasCounter"> Total number of aliases. </param>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <param name="vectorIndexSizeCounter"> Total memory consumption of all vector indexes within the service, in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasCounter"/>, <paramref name="documentCounter"/>, <paramref name="indexCounter"/>, <paramref name="indexerCounter"/>, <paramref name="dataSourceCounter"/>, <paramref name="storageSizeCounter"/>, <paramref name="synonymMapCounter"/>, <paramref name="skillsetCounter"/> or <paramref name="vectorIndexSizeCounter"/> is null. </exception>
        internal SearchServiceCounters(SearchResourceCounter aliasCounter, SearchResourceCounter documentCounter, SearchResourceCounter indexCounter, SearchResourceCounter indexerCounter, SearchResourceCounter dataSourceCounter, SearchResourceCounter storageSizeCounter, SearchResourceCounter synonymMapCounter, SearchResourceCounter skillsetCounter, SearchResourceCounter vectorIndexSizeCounter)
        {
            Argument.AssertNotNull(aliasCounter, nameof(aliasCounter));
            Argument.AssertNotNull(documentCounter, nameof(documentCounter));
            Argument.AssertNotNull(indexCounter, nameof(indexCounter));
            Argument.AssertNotNull(indexerCounter, nameof(indexerCounter));
            Argument.AssertNotNull(dataSourceCounter, nameof(dataSourceCounter));
            Argument.AssertNotNull(storageSizeCounter, nameof(storageSizeCounter));
            Argument.AssertNotNull(synonymMapCounter, nameof(synonymMapCounter));
            Argument.AssertNotNull(skillsetCounter, nameof(skillsetCounter));
            Argument.AssertNotNull(vectorIndexSizeCounter, nameof(vectorIndexSizeCounter));

            AliasCounter = aliasCounter;
            DocumentCounter = documentCounter;
            IndexCounter = indexCounter;
            IndexerCounter = indexerCounter;
            DataSourceCounter = dataSourceCounter;
            StorageSizeCounter = storageSizeCounter;
            SynonymMapCounter = synonymMapCounter;
            SkillsetCounter = skillsetCounter;
            VectorIndexSizeCounter = vectorIndexSizeCounter;
        }

        /// <summary> Total number of aliases. </summary>
        public SearchResourceCounter AliasCounter { get; }
        /// <summary> Total number of documents across all indexes in the service. </summary>
        public SearchResourceCounter DocumentCounter { get; }
        /// <summary> Total number of indexes. </summary>
        public SearchResourceCounter IndexCounter { get; }
        /// <summary> Total number of indexers. </summary>
        public SearchResourceCounter IndexerCounter { get; }
        /// <summary> Total number of data sources. </summary>
        public SearchResourceCounter DataSourceCounter { get; }
        /// <summary> Total size of used storage in bytes. </summary>
        public SearchResourceCounter StorageSizeCounter { get; }
        /// <summary> Total number of synonym maps. </summary>
        public SearchResourceCounter SynonymMapCounter { get; }
        /// <summary> Total number of skillsets. </summary>
        public SearchResourceCounter SkillsetCounter { get; }
        /// <summary> Total memory consumption of all vector indexes within the service, in bytes. </summary>
        public SearchResourceCounter VectorIndexSizeCounter { get; }
    }
}
