namespace DSA.LinkedList;

public class Order{
    public string OrderDetails { get; set; }
    public Order Next { get; set; }

    public Order (string details){
        OrderDetails = details;
        Next = null;
    }
}

public class OrderQueue{
    private Order front;
    private Order back;

    public OrderQueue(){
        front = null;
        back = null;
    }

    public void Enqueue(string orderDetails){
        Order newOrder = new Order(orderDetails);

        if(back == null){
            front = back = newOrder;
        }
        else
        {
            back.Next = newOrder;
            back = newOrder;
        }
        Console.WriteLine($"Order added: {orderDetails}");
    }

    public string Dequeue(){
        if(front == null){
            Console.WriteLine("Order queue is empty, no order to process...");
            return null;
        }

        string orderDetails = front.OrderDetails;
        front = front.Next;

        if(front == null){
            back = null;
        }

        Console.WriteLine($"Order processed: {orderDetails}");
        return orderDetails;
    }


    public string Peek(){
        if(front == null){
            Console.WriteLine("Order Queue is empty");
            return null;
        }
        return front.OrderDetails;
    }

    public bool IsEmpty(){
        return front == null;
    }

}
