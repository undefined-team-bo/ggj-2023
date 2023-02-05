// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using UnityEngine;
	using Coherence.Toolkit;
	using Coherence.Toolkit.Bindings;
	using Coherence.Entity;
	using Coherence.ProtocolDef;
	using Coherence.Brook;
	using Coherence.Toolkit.Bindings.ValueBindings;
	using Coherence.Toolkit.Bindings.TransformBindings;
	using Coherence.Connection;
	using Coherence.Log;
	using Logger = Coherence.Log.Logger;
	using UnityEngine.Scripting;

	public class Binding_c9d321b103129184eb302bb638fd65ac_ddce0dcc_34b1_4958_a0ff_ec70924658ac : BoolBinding
	{
		private UnityEngine.MeshRenderer CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (UnityEngine.MeshRenderer)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override bool Value
		{
			get => (bool)(System.Boolean)(CastedUnityComponent.enabled);
			set => CastedUnityComponent.enabled = (System.Boolean)(value);
		}

		protected override bool ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546)coherenceComponent;
			return update.enabled;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546)coherenceComponent;
			update.enabled = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546();
		}
	}

	public class Binding_c9d321b103129184eb302bb638fd65ac_13e1af2f_bc9f_4bbc_a36d_5142c7927c77 : FloatBinding
	{
		private TreeController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TreeController)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_TreeController_6230497222636945137";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override float Value
		{
			get => (float)(System.Single)(CastedUnityComponent.HealthB);
			set => CastedUnityComponent.HealthB = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			return update.HealthB;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			update.HealthB = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_TreeController_6230497222636945137();
		}
	}

	public class Binding_c9d321b103129184eb302bb638fd65ac_4a5c9dac_5a86_4615_882a_6343da09763f : FloatBinding
	{
		private TreeController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TreeController)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_TreeController_6230497222636945137";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override float Value
		{
			get => (float)(System.Single)(CastedUnityComponent.HealthG);
			set => CastedUnityComponent.HealthG = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			return update.HealthG;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			update.HealthG = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_TreeController_6230497222636945137();
		}
	}

	public class Binding_c9d321b103129184eb302bb638fd65ac_0bd476b5_f426_44cb_ba27_c239dc028131 : FloatBinding
	{
		private TreeController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TreeController)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_TreeController_6230497222636945137";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override float Value
		{
			get => (float)(System.Single)(CastedUnityComponent.HealthR);
			set => CastedUnityComponent.HealthR = (System.Single)(value);
		}

		protected override float ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			return update.HealthR;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			update.HealthR = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_TreeController_6230497222636945137();
		}
	}

	public class Binding_c9d321b103129184eb302bb638fd65ac_655eae4f_f777_4f93_8eed_fec3431f3688 : Vector3Binding
	{
		private TreeController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TreeController)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_TreeController_6230497222636945137";

		public override uint FieldMask => 0b00000000000000000000000000001000;

		public override Vector3 Value
		{
			get => (Vector3)(UnityEngine.Vector3)(CastedUnityComponent.lastColor);
			set => CastedUnityComponent.lastColor = (UnityEngine.Vector3)(value);
		}

		protected override Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			return update.lastColor;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			update.lastColor = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_TreeController_6230497222636945137();
		}
	}

	public class Binding_c9d321b103129184eb302bb638fd65ac_5ce9e326_1943_4330_92c6_88481e491bc8 : IntBinding
	{
		private TreeController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (TreeController)UnityComponent;
		}
		public override string CoherenceComponentName => "Tree_id1_TreeController_6230497222636945137";

		public override uint FieldMask => 0b00000000000000000000000000010000;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.lastQuantity);
			set => CastedUnityComponent.lastQuantity = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			return update.lastQuantity;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Tree_id1_TreeController_6230497222636945137)coherenceComponent;
			update.lastQuantity = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Tree_id1_TreeController_6230497222636945137();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'Tree' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncTree_id1 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands		
		private TreeController Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6_CommandTarget;

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncTree_id1>();
			if (coherenceSync.TryGetBindingByGuid("ef71c32f-f905-4f7b-a7cf-278da698afe6", "RestoreHealthNet", out Binding Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6))
			{
				Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6_CommandTarget = (TreeController)Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6.UnityComponent;
				coherenceSync.AddCommandRequestDelegate("TreeController.RestoreHealthNet", "()",
				SendCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6, ReceiveLocalCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6, MessageTarget.AuthorityOnly, Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6_CommandTarget,false);
			}
			else
			{
				logger.Error("Couldn't find command binding (RestoreHealthNet)");
			}
			if (coherenceSync.TryGetBindingByGuid("ddce0dcc-34b1-4958-a0ff-ec70924658ac", "enabled", out Binding InternalTree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_enabled))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_ddce0dcc_34b1_4958_a0ff_ec70924658ac();
				InternalTree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_enabled.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_Tree_id1_UnityEngine__char_46_MeshRenderer_6944398059840426546_enabled)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (UnityEngine.MeshRenderer).enabled");
			}
			if (coherenceSync.TryGetBindingByGuid("13e1af2f-bc9f-4bbc-a36d-5142c7927c77", "HealthB", out Binding InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthB))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_13e1af2f_bc9f_4bbc_a36d_5142c7927c77();
				InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthB.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthB)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TreeController).HealthB");
			}
			if (coherenceSync.TryGetBindingByGuid("4a5c9dac-5a86-4615-882a-6343da09763f", "HealthG", out Binding InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthG))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_4a5c9dac_5a86_4615_882a_6343da09763f();
				InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthG.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthG)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TreeController).HealthG");
			}
			if (coherenceSync.TryGetBindingByGuid("0bd476b5-f426-44cb-ba27-c239dc028131", "HealthR", out Binding InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthR))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_0bd476b5_f426_44cb_ba27_c239dc028131();
				InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthR.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_HealthR)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TreeController).HealthR");
			}
			if (coherenceSync.TryGetBindingByGuid("655eae4f-f777-4f93-8eed-fec3431f3688", "lastColor", out Binding InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastColor))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_655eae4f_f777_4f93_8eed_fec3431f3688();
				InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastColor.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastColor)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TreeController).lastColor");
			}
			if (coherenceSync.TryGetBindingByGuid("5ce9e326-1943-4330-92c6-88481e491bc8", "lastQuantity", out Binding InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastQuantity))
			{
				var clone = new Binding_c9d321b103129184eb302bb638fd65ac_5ce9e326_1943_4330_92c6_88481e491bc8();
				InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastQuantity.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalTree_id1_TreeController_6230497222636945137_Tree_id1_TreeController_6230497222636945137_lastQuantity)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (TreeController).lastQuantity");
			}
		}

		public override List<ICoherenceComponentData> CreateEntity()
		{
			if (coherenceSync.UsesLODsAtRuntime && (Archetypes.IndexForName.TryGetValue(coherenceSync.Archetype.ArchetypeName, out int archetypeIndex)))
			{
				var components = new List<ICoherenceComponentData>()
				{
					new ArchetypeComponent
					{
						index = archetypeIndex
					}
				};

				return components;
			}
			else
			{
				logger.Warning($"Unable to find archetype {coherenceSync.Archetype.ArchetypeName} in dictionary. Please, bake manually (coherence > Bake)");
			}

			return null;
		}

		public override void Initialize(CoherenceSync sync, IClient client)
		{
			if (coherenceSync == null)
			{
				coherenceSync = sync;
			}
			this.client = client;
		}
		void SendCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6(MessageTarget target, object[] args)
		{
			var command = new Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6();
			client.SendCommand(command, target, coherenceSync.EntityID);
		}

		void ReceiveLocalCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6(MessageTarget target, object[] args)
		{
			var command = new Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6();
			ReceiveCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6(command);
		}

		void ReceiveCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6(Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6 command)
		{
			var target = Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6_CommandTarget;
			target.RestoreHealthNet();
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				case Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6 castedCommand:
					ReceiveCommand_Tree_id1_TreeController__char_46_RestoreHealthNet_ef71c32f_f905_4f7b_a7cf_278da698afe6(castedCommand);
					break;
				default:
					logger.Warning($"[CoherenceSyncTree_id1] Unhandled command: {command.GetType()}.");
					break;
			}
		}
	}
}
