// Interface that will be inherited by Rover and Satellite
interface IDirectable
{
    // It will have 3 methods
    string GetInfo();
    string Explore();
    string Collect();
}