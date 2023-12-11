using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node
{
    private int currentChildID = 0;

    public Selector(string tag) : base(tag) { }
    public Selector(string tag, IEnumerable<Node> children)
        : base(tag, children) { }
    protected override NodeState InnerEvaluate()
    {
        while (currentChildID < Children.Count)
        {
            var currentChild = Children[currentChildID];
            NodeState childState = currentChild.Evaluate();

            if (childState == NodeState.Failure)
            {
                currentChildID++;
            }
            else if (childState == NodeState.Running)
            {
                return NodeState.Running;
            }
            else // NodeState.Success
            {
                State = NodeState.Success;
                currentChildID = 0;
                return NodeState.Success;
            }
        }

        // All children have been evaluated, and none have succeeded.
        State = NodeState.Failure;
        currentChildID = 0; // Reset for the next evaluation.
        return NodeState.Failure;
    }
}