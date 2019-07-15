﻿// Copyright (c) 2012-2019 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using Dicom.Network;
using System;
using System.Collections.Generic;
using System.Threading;
using Worklist_SCP.Model;

namespace Worklist_SCP
{
   public class WorklistServer
   {

      private static IDicomServer _server;
      private static Timer _itemsLoaderTimer;


      protected WorklistServer()
      {
      }

      public static string AETitle { get; set; }


      public static IWorklistItemsSource CreateItemsSourceService => new WorklistItemsProvider();

      public static List<WorklistItem> CurrentWorklistItems { get; private set; }

      public static void Start(int port, string aet, List<WorklistItem> list)
        {
         AETitle = aet;
         _server = DicomServer.Create<WorklistService>(port);
         // every 30 seconds the worklist source is queried and the current list of items is cached in _currentWorklistItems
         _itemsLoaderTimer = new Timer((state) =>
         {
             if (list.Count != 0)
             {
                 CurrentWorklistItems = list;
             }
             else
             {
                 var newWorklistItems = CreateItemsSourceService.GetAllCurrentWorklistItems();
                 CurrentWorklistItems = newWorklistItems;
             } 
         }, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
      }

        public static void Stop()
      {
         _server.Dispose();
      }


   }
}
