from behave import given, then
from hamcrest import *
from bearandsteadygene import BearAndSteadyGene


@given('Create an instance of BASGKata Gene: "{gene}", Length: "{length}"')
def step(context, length,gene):
    context.solution = BearAndSteadyGene(int(length),gene)


@then('Cortege of repetitions letters from "{gene}" is "{cortege}"')
def step(context,gene,cortege):
        assert_that(context.solution.calc_count_of_repetitions(gene),equal_to(toIntArray(str.split(cortege, sep=','))))


@then('Cortege of excesses letters from "{gene}" is "{cortege}"')
def step(context,gene,cortege):
        assert_that(context.solution.get_excess_elements(toIntArray(str.split(gene,sep=','))),equal_to(toIntArray(str.split(cortege, sep=','))))


@then('Cortege "{first}" contains cortege "{second}"... Is "{boolka}"')
def step_impl(context, first, second, boolka):
    assert_that(
        str(context.solution.contains_cortege(
        toIntArray(first.split(',')),
        toIntArray(second.split(',')))),
        equal_to(boolka))


@then('Minimal substring length of this gene = "{result}"')
def step_impl(context, result):
    assert_that(context.solution.get_minimal_substring_length(), equal_to(int(result)))


def toIntArray(strArray):
    array = []
    for i in strArray:
        array.append(int(i))
    return array