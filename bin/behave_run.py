#!/usr/bin/env python
# -*- coding: UTF-8 -*-
# =============================================================================
# REUSE LOCAL BEHAVE, if available
# =============================================================================

import os.path
import sys

# ----------------------------------------------------------------------------
# PROJECT-SPECIFIC SETUP PATHS:
# ----------------------------------------------------------------------------
import project_sitecustomize

# ----------------------------------------------------------------------------
# BEHAVE-PATCHES:
# ----------------------------------------------------------------------------


def monkeypatch_behave():
    """
    from project_sitecustomize import project_workspace_addsitedir, PYTHON_LIBDIR
    project_workspace_addsitedir(PYTHON_LIBDIR)
    """

    """
    Apply patches to "behave" to make documenation runs work.
    from behave_ext.terminal.ansiterm import AnsiStyle
    from behave_ext.terminal import ansi_escapes as ansi_escapes2
    """
    from behave.formatter import ansi_escapes
    ansi_escapes.colors["grey"] = ansi_escapes.colors["white"]
    ansi_escapes.use_ansi_escape_colorbold_composites()
    """
    ansi_escapes2.AnsiColor.grey = ansi_escapes2.AnsiColor.white
    ansi_escapes2.colors["grey"] = ansi_escapes.colors["white"]
    AnsiStyle.parse_style = staticmethod(AnsiStyle.parse_style2)
    """


def setup_behave():
    """
    Apply tweaks, extensions and patches to "behave".
    """
    from behave.configuration import Configuration
    # -- DISABLE: Timings to simplify issue.features/ tests.
    Configuration.defaults["show_timings"] = False


def behave_main0():
    from behave.__main__ import main as behave_main
    monkeypatch_behave()
    setup_behave()
    return behave_main()

# ----------------------------------------------------------------------------
# MAIN:
# ----------------------------------------------------------------------------
if __name__ == "__main__":
    os.environ["BEHAVE_TERM_STYLE"] = "blue"
    sys.exit(behave_main0())
