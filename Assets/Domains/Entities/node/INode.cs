using System.Collections.Generic;

namespace towerdefence_node {
	public interface INode{
		internal HashSet<INode> NodeIncoming{get ;}
		internal HashSet<INode> NodeOutcoming{get ;}
		internal float CapacityOutcoming{get ;}
		internal float CapacityIncoming{get ;}
		internal float CapacityContain{get ;}
	}
}