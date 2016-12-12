from behave import given, then
from hamcrest import *
from labyrinth import Labyrinth


@given('Create an instance of Labyrinth n:"{n}" array: "{array}"')
def step(context, n, array):
    context.labi = Labyrinth(n, array.split())


@then('S-Position = "{position1}", E-Position = "{position2}"')
def step_impl(context, position1, position2):
    assert_that(context.labi.s_e_search(),equal_to((toIntArray(position1), toIntArray(position2))))


@then('Element x= "{x}", y= "{y}" == "{result}"')
def step_impl(context, x, y,result):
    assert_that(context.labi.get_element(x,y), equal_to(result))


@then('Path from s to e: "{path}"')
def step_impl(context, path):
    assert_that(context.labi.start(), equal_to(path.split(',')))


def toIntArray(strArray):
    array = []
    for i in strArray:
        array.append(int(i))
    return array