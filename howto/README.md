# How to write Katas with python and behave

`behave`_ is a BDD test framework and cucumber-clone for Python.
This project provides tutorials and examples how to use `behave`_.
It should extends the excellent documentation of `behave`_.

## Install

The project provides tutorials and examples.
Therefore, it should not be installed.
To prepare the local installation, use the following command to install
all prerequisites::

    pip install -r requirements.txt

Snapshots of the `behave`_ and `parse_type`_ implementations
are provided in the directory ``lib/python/``.  This directory is
automatically used when you use ``bin/behave`` to run `behave`_.

## Usage

Cleanup local workspace:

    paver clean

Run `behave`_ tests:

    paver test

or:

    bin/behave features/

If `paver`_ is not installed, use the following canned script instead::

    bin/paver command ...

### References

* behave:  http://pypi.python.org/pypi/behave/
* cucumber: http://cukes.info/

Repositories:
  * [behave](https://github.com/behave/behave)
  * [parse_type](https://github.com/behave/parse_type)