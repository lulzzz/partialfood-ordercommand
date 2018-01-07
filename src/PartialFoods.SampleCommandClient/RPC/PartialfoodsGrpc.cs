// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: partialfoods.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace PartialFoods.Services {
  public static partial class OrderCommand
  {
    static readonly string __ServiceName = "PartialFoods.Services.OrderCommand";

    static readonly grpc::Marshaller<global::PartialFoods.Services.OrderRequest> __Marshaller_OrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PartialFoods.Services.OrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PartialFoods.Services.OrderResponse> __Marshaller_OrderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PartialFoods.Services.OrderResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::PartialFoods.Services.OrderRequest, global::PartialFoods.Services.OrderResponse> __Method_SubmitOrder = new grpc::Method<global::PartialFoods.Services.OrderRequest, global::PartialFoods.Services.OrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitOrder",
        __Marshaller_OrderRequest,
        __Marshaller_OrderResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PartialFoods.Services.PartialfoodsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OrderCommand</summary>
    public abstract partial class OrderCommandBase
    {
      public virtual global::System.Threading.Tasks.Task<global::PartialFoods.Services.OrderResponse> SubmitOrder(global::PartialFoods.Services.OrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OrderCommand</summary>
    public partial class OrderCommandClient : grpc::ClientBase<OrderCommandClient>
    {
      /// <summary>Creates a new client for OrderCommand</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OrderCommandClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OrderCommand that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OrderCommandClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OrderCommandClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OrderCommandClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::PartialFoods.Services.OrderResponse SubmitOrder(global::PartialFoods.Services.OrderRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitOrder(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PartialFoods.Services.OrderResponse SubmitOrder(global::PartialFoods.Services.OrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitOrder, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PartialFoods.Services.OrderResponse> SubmitOrderAsync(global::PartialFoods.Services.OrderRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubmitOrderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PartialFoods.Services.OrderResponse> SubmitOrderAsync(global::PartialFoods.Services.OrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitOrder, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OrderCommandClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OrderCommandClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OrderCommandBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SubmitOrder, serviceImpl.SubmitOrder).Build();
    }

  }
}
#endregion
