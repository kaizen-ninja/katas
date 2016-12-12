from behave import given, then
from hamcrest import *
from equi import Equi


@given('Create an instance of Equi array: "{array}"')
def step(context, array):
    context.eq = Equi(array.split(','), 4)


@then('Element "{number}" Is Equilibrium. It`s "{result}"')
def step_impl(context,number,result):
    assert_that(bool(is_(context.eq.is_equilibrium(number))), is_(bool(result)))


@then('All Equilibrium Indexes is: "{result}"')
def step_impl(context,result):
    assert_that(context.eq.get_equilibrium_indexes(), equal_to(toIntArray(str.split(result, sep=','))))


def toIntArray(strArray):
    array = []
    for i in strArray:
        array.append(int(i))
    return array