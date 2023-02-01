# 网关学习

风关只暴露最外面那层，内部只有程序员自己就可以了



## 配置文件 

配置文件可以根据自己需求要修改

```json
{
  //路由配置  
  "Routes": [
    {
      //下行路径模板 //对程序内的
      "DownstreamPathTemplate": "/api/{url}", //服务地址-url变量
      "DownstreamScheme": "http", //https
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost", //主机
          "Port": 5124 //服务端口
        }
      ],
      "UpstreamPathTemplate": "/api1/{url}", //网关地址--url变量
      "UpstreamHttpMethod": [ "Get", "Post", "Put", "Delete" ] //http请求方式

    }
  ]
}
```

### 负载均衡

```josn
{
  //路由配置  
  "Routes": [
    {
      //下行路径模板 //对程序内的
      "DownstreamPathTemplate": "/api/{url}", //服务地址-url变量
      "DownstreamScheme": "http", //https
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost", //主机
          "Port": 5124 //服务端口
        }, //多级地址
        {
          "Host": "localhost", //主机
          "Port": 5125 //服务端口
        },
        {
          "Host": "localhost", //主机
          "Port": 5126 //服务端口
        }
      ],
      "UpstreamPathTemplate": "/api1/{url}", //网关地址--url变量
      "UpstreamHttpMethod": [ "Get", "Post", "Put", "Delete" ], //http请求方式
      "LoadBalancerOptions": { //负载均衡
        "Type": "RoundRobin" //轮询 //"LeastConnection" 最少连接数的服务器    "CookieStickySessions" 粘性会话 //"NoLoadBalancer" 从配置或服务发现中获取第一个可用服务。 
      }
    }
  ]
}
```









dotnet Dream.Gateway.Ocelot.dll

dotnet Dream.Gateway.Api1.dll

dotnet Dream.Gateway.LoadBalancer.dll

