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

	public class Binding_2f37b1be90c58714f91aba02c042dfd9_c44701fd_3575_4d4b_931b_dcb485a4b966 : IntBinding
	{
		private PlayerController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerController)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerController_7430135086103731642";

		public override uint FieldMask => 0b00000000000000000000000000000001;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.actualInventory);
			set => CastedUnityComponent.actualInventory = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			return update.actualInventory;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			update.actualInventory = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerController_7430135086103731642();
		}
	}

	public class Binding_2f37b1be90c58714f91aba02c042dfd9_b657e0c2_4130_4d46_ab72_3c3f6167c30e : IntBinding
	{
		private PlayerController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerController)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerController_7430135086103731642";

		public override uint FieldMask => 0b00000000000000000000000000000010;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.B);
			set => CastedUnityComponent.B = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			return update.B;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			update.B = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerController_7430135086103731642();
		}
	}

	public class Binding_2f37b1be90c58714f91aba02c042dfd9_eadc0e9d_ea27_43f7_bbc2_254780774428 : IntBinding
	{
		private PlayerController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerController)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerController_7430135086103731642";

		public override uint FieldMask => 0b00000000000000000000000000000100;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.G);
			set => CastedUnityComponent.G = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			return update.G;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			update.G = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerController_7430135086103731642();
		}
	}

	public class Binding_2f37b1be90c58714f91aba02c042dfd9_7afbc4e3_02d6_4ae7_bff7_b0163b158e6d : IntBinding
	{
		private PlayerController CastedUnityComponent;		

		protected override void OnBindingCloned()
		{
			CastedUnityComponent = (PlayerController)UnityComponent;
		}
		public override string CoherenceComponentName => "Player_id0_PlayerController_7430135086103731642";

		public override uint FieldMask => 0b00000000000000000000000000001000;

		public override int Value
		{
			get => (int)(System.Int32)(CastedUnityComponent.R);
			set => CastedUnityComponent.R = (System.Int32)(value);
		}

		protected override int ReadComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			return update.R;
		}
		
		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent)
		{
			var update = (Player_id0_PlayerController_7430135086103731642)coherenceComponent;
			update.R = Value;
			return update;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return new Player_id0_PlayerController_7430135086103731642();
		}
	}


	[Preserve]
	[AddComponentMenu("coherence/Baked/Baked 'Player' (auto assigned)")]
	[RequireComponent(typeof(CoherenceSync))]
	public class CoherenceSyncPlayer_id0 : CoherenceSyncBaked
	{
		private CoherenceSync coherenceSync;
		private Logger logger;

		// Cached targets for commands

		private IClient client;
		private CoherenceMonoBridge monoBridge => coherenceSync.MonoBridge;

		protected void Awake()
		{
			coherenceSync = GetComponent<CoherenceSync>();
			coherenceSync.usingReflection = false;

			logger = coherenceSync.logger.With<CoherenceSyncPlayer_id0>();
			if (coherenceSync.TryGetBindingByGuid("c44701fd-3575-4d4b-931b-dcb485a4b966", "actualInventory", out Binding InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_actualInventory))
			{
				var clone = new Binding_2f37b1be90c58714f91aba02c042dfd9_c44701fd_3575_4d4b_931b_dcb485a4b966();
				InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_actualInventory.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_actualInventory)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerController).actualInventory");
			}
			if (coherenceSync.TryGetBindingByGuid("b657e0c2-4130-4d46-ab72-3c3f6167c30e", "B", out Binding InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_B))
			{
				var clone = new Binding_2f37b1be90c58714f91aba02c042dfd9_b657e0c2_4130_4d46_ab72_3c3f6167c30e();
				InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_B.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_B)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerController).B");
			}
			if (coherenceSync.TryGetBindingByGuid("eadc0e9d-ea27-43f7-bbc2-254780774428", "G", out Binding InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_G))
			{
				var clone = new Binding_2f37b1be90c58714f91aba02c042dfd9_eadc0e9d_ea27_43f7_bbc2_254780774428();
				InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_G.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_G)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerController).G");
			}
			if (coherenceSync.TryGetBindingByGuid("7afbc4e3-02d6-4ae7-bff7-b0163b158e6d", "R", out Binding InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_R))
			{
				var clone = new Binding_2f37b1be90c58714f91aba02c042dfd9_7afbc4e3_02d6_4ae7_bff7_b0163b158e6d();
				InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_R.CloneTo(clone);
				coherenceSync.Bindings[coherenceSync.Bindings.IndexOf(InternalPlayer_id0_PlayerController_7430135086103731642_Player_id0_PlayerController_7430135086103731642_R)] = clone;
			}
			else
			{
				logger.Error("Couldn't find binding (PlayerController).R");
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

		public override void ReceiveCommand(IEntityCommand command)
		{
			switch(command)
			{
				default:
					logger.Warning($"[CoherenceSyncPlayer_id0] Unhandled command: {command.GetType()}.");
					break;
			}
		}
	}
}
