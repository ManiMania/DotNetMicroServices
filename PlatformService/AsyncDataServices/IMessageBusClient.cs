using PlatformService.Dtos;

namespace PlatformService.AsycDataServices;

public interface IMessageBusClient
{
    void PublishNewPlatform(PlatformPublishedDto platformPublishDto);

}