# BizAuthorised - idea

Creation of attributes to be added into business services where permission checks need to happen.

This would allow us to maintain central collection of role to business actions.

To enforce the check simply add a [BizAuthorized] attribute to a method or class.

You could then swap out your implementation of the UserResolver to grab from the HttpContext for instances.

You can also change the behaviour of the attribute by swapping out the BizFilter implementation.

Idea: you could create an instance that logged a user as he moved through the system to reverse engineer the allow methods for a role! :)

The entire premise hinge on the IL weaving magic of Fody.  The only shitty part is the MethodDecorator weaver reflects the method name out.  It would be really cool if we could boil this down to a string at compile time (not sure if this is possible.)  Would give a nice performance bump.