# -*- coding: UTF-8 -*-
# MISSING-DOCSTRING: pylint: disable=C0111
"""
Based on ``behave tutorial``

Feature: Fight or Flight (Natural Language)
    In order to increase the ninja survival rate,   #< Business goal
    As a ninja commander                            #< Role
    I want my ninjas to decide whether to take on an opponent   #< Benefit
        based on their skill levels

    Scenario: Weaker opponent
        Given the ninja has a third level black-belt
        When attacked by a samurai
        Then the ninja should engage the opponent

    Scenario: Stronger opponent
        Given the ninja has a third level black-belt
        When attacked by Chuck Norris
        Then the ninja should run for his life
"""

# @mark.domain_model
# ----------------------------------------------------------------------------
# PROBLEM DOMAIN:
# ----------------------------------------------------------------------------


class NinjaFight(object):
    """
    Domain model for ninja fights.
    """
    # pylint: disable=R0903

    def __init__(self, with_ninja_level=None):
        self.with_ninja_level = with_ninja_level
        self.opponent = None

    def decision(self):
        """
        Business logic how a Ninja should react to increase his survival rate.
        """
        assert self.with_ninja_level is not None
        assert self.opponent is not None
        if self.opponent == "Chuck Norris":
            return "run for his life"
        if "black-belt" in self.with_ninja_level:
            return "engage the opponent"
        else:
            return "run for his life"

