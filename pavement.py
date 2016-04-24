# ============================================================================
# PAVER MAKEFILE (pavement.py) -- behave.example
# ============================================================================
# REQUIRES: paver >= 1.2
# DESCRIPTION:
#   Provides platform-neutral "Makefile" for simple, project-specific tasks.
#
# USAGE:
#   paver TASK [OPTIONS...]
#   paver help           -- Show all supported commands/tasks.
#   paver clean          -- Cleanup project workspace.
#   paver test           -- Run all tests (unittests, examples).
#
# SEE ALSO:
#  * http://pypi.python.org/pypi/Paver/
#  * http://www.blueskyonmars.com/projects/paver/
# ============================================================================

from paver.easy import *
import sys

sys.path.insert(0, ".")

# -- PAVER-EXTENSIONS: More tasks and utilities...
# NOT-USED: import paver.doctools
from paver.setuputils import setup, install_distutils_tasks
from paver_ext.pip_download import download_deps, localpi
from paver_ext.python_checker import pychecker, pylint
from paver_ext.python_requirements import read_requirements
from paver_ext.paver_consume_args import Cmdline
from paver_ext import paver_require, paver_patch

paver_require.min_version("1.2")
paver_patch.ensure_path_with_pmethods(path)
paver_patch.ensure_path_with_smethods(path)

# -- REQUIRED-FOR: setup, sdist, ...
# NOTE: Adds a lot more python-project related tasks.
install_distutils_tasks()

# ----------------------------------------------------------------------------
# PROJECT CONFIGURATION (for sdist/setup mostly):
# ----------------------------------------------------------------------------
NAME = "behave.example"

# ----------------------------------------------------------------------------
# TASK CONFIGURATION:
# ----------------------------------------------------------------------------
options(
    minilib=Bunch(
        extra_files=['virtual']
    ),
    pip=Bunch(
        requirements_files=[
            "requirements.txt",
        ],
        # download_dir="downloads",
        download_dir=path("$HOME/.pip/downloads").expandvars(),
    ),
    test=Bunch(
        default_args=[
            "features/"
        ],
        behave_cmdopts="--tags=-@xfail",
        behave_formatter="progress",
    ),
    pychecker=Bunch(default_args=NAME),
    pylint=Bunch(default_args=NAME)
)


# ----------------------------------------------------------------------------
# TASKS:
# ----------------------------------------------------------------------------


@task
def init():
    """Initialze workspace."""
    path("build").makedirs_s()


# ----------------------------------------------------------------------------
# TASK: test
# ----------------------------------------------------------------------------


@task
@consume_args
@needs("init")
def test(args):
    """Execute all tests"""
    call_task("behave_test")


@task
@consume_args
@needs("init")
def behave_test(args):
    """Execute tests with behave"""
    if not args:
        args = options.test.default_args
    behave_cmdopts = "-f {formatter} {opts}".format(
        formatter=options.test.behave_formatter,
        opts=options.test.behave_cmdopts,
    )

    for arg in args:
        behave(arg, options=behave_cmdopts)


# ----------------------------------------------------------------------------
# TASK: clean
# ----------------------------------------------------------------------------


@task
def clean():
    """Cleanup the project workspace."""

    # -- STEP: Remove build directories.
    path("build").rmtree_s()
    path("dist").rmtree_s()
    path("test_results").rmtree_s()
    path(".tox").rmtree_s()

    # -- STEP: Remove temporary directory subtrees.
    patterns = [
        "*.egg-info",
        ".cache",  # < py.test cache directory.
        "__pycache__",  # < Python compiled objects cache.
    ]
    sys_prefix = path(sys.prefix).relpath()
    for pattern in patterns:
        dirs = path(".").walkdirs(pattern, errors="ignore")
        for d in dirs:
            d = d.normpath()
            if d.startswith(sys_prefix):
                info("SKIP: %s" % d)
                continue  # SKIP-SUICIDE: .venv*, .tox
            d.rmtree()

    # -- STEP: Remove files.
    path(".coverage").remove_s()
    path("paver-minilib.zip").remove_s()

    # -- STEP: Remove temporary files.
    patterns = [
        "*.pyc", "*.pyo", "*$py.class",
        "*.bak", "*.log", "*.tmp",
        "*.output", "rerun.featureset",
        ".coverage", ".coverage.*",
        "pylint_*.txt", "pychecker_*.txt",
        ".DS_Store", "*.~*~",  # < MACOSX
    ]
    for pattern in patterns:
        files = path(".").walkfiles(pattern)
        for f in files:
            f = f.normpath()
            if f.startswith(sys_prefix):
                continue  # SKIP-CLEANUP: .venv*, .tox
            f.remove()


@task
def clean_all():
    """Clean everything, like in newly installed state."""
    path("downloads").rmtree_s()

    # -- MORE: Use normal cleanings, too.
    call_task("clean")


# ----------------------------------------------------------------------------
# UTILS:
# ----------------------------------------------------------------------------
HERE = path(__file__).dirname()
BEHAVE = HERE.joinpath("bin/behave")
if sys.platform == "win32":
    BEHAVE = path(BEHAVE).normpath()


def python(cmdline, cwd="."):
    """Execute a python script by using the current python interpreter."""
    return sh("%s %s" % (sys.executable, cmdline), cwd=cwd)


def behave(args, options=""):
    """Run the behave command"""
    return sh("{behave} {options} {args}".format(
        behave=BEHAVE, options=options, args=args))
